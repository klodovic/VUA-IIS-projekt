using ClientApp.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ClientApp
{
    public partial class Trophy : Form
    {
        const string xsd = "http://localhost:5000/api/Trophy/XSD";
        const string rng = "http://localhost:5000/api/Trophy/RNG";
        List<Trophy> retrunedValues = new List<Trophy>();
        Model.Trophy t;
        string key;
        string value;

        public Trophy()
        {
            InitializeComponent();
            populateComboBox();
        }

        private void populateComboBox()
        {
            cbNode.Items.Add("League");
            cbNode.Items.Add("Country");
            cbNode.Items.Add("Season");
            cbNode.Items.Add("Place");
            cbNode.SelectedIndex = 0;
        }


        //1. i 2. Novi entitet - POST - Validacija XSD i RNG
        private void addTrophy_Click(object sender, EventArgs e)
        {
            bool check = validation();

            if (check)
            {
                t = createNewTrophy();
                DataContractSerializer serializer = new DataContractSerializer(typeof(Model.Trophy));
                MemoryStream stream = new MemoryStream();
                XmlWriter xmlWriter = XmlWriter.Create(stream);
                serializer.WriteObject(xmlWriter, t);
                xmlWriter.Close();

                byte[] podaci = Encoding.UTF8.GetBytes(Encoding.UTF8.GetString(stream.ToArray()));

                HttpWebRequest zahtjev;
                if (rbXSD.Checked)
                {
                    zahtjev = WebRequest.CreateHttp(xsd);
                }
                else
                {
                    zahtjev = WebRequest.CreateHttp(rng);
                }

                zahtjev.Accept = "application/json";
                zahtjev.Method = "POST";
                zahtjev.ContentType = "application/xml";
                Stream bodyRequest = zahtjev.GetRequestStream();
                bodyRequest.Write(podaci, 0, podaci.Length);
                bodyRequest.Close();

                try
                {
                    HttpWebResponse odgovor = (HttpWebResponse)zahtjev.GetResponse();
                    if (odgovor.StatusCode == HttpStatusCode.Accepted)
                    {
                        lblInfo.Visible = true;
                        lblInfo.ForeColor = Color.Green;
                        lblInfo.Text = "Validation Passed!!";
                    }

                    if (odgovor.StatusCode == HttpStatusCode.PartialContent)
                    {
                        lblInfo.Visible = true;
                        lblInfo.ForeColor = Color.Red;
                        lblInfo.Text = "Validation Failed!!";
                    }
                }
                catch (Exception)
                {
                    printBadRequest();
                }
            }
            else
            {
                lblInfo.Visible = true;
                lblInfo.ForeColor = Color.Red;
                lblInfo.Text = "All fields are required!!";
            }          
        }

        private bool validation()
        {
            List<TextBox> boxes = new List<TextBox>() {txtLeague, txtCountry, txtSeason, txtPlace};
            foreach (var item in boxes)
            {
                if (String.IsNullOrEmpty(item.Text.Trim()))
                {
                    return false;
                }
            }
            return true;
        }

        private void printBadRequest()
        {
            lblInfo.Visible = true;
            lblInfo.ForeColor = Color.Red;
            lblInfo.Text = "400 Bad Request!!";
        }

        private Model.Trophy createNewTrophy()
        {
            Model.Trophy trophy = new Model.Trophy(
                txtLeague.Text.Trim(),
                txtCountry.Text.Trim(),
                txtSeason.Text.Trim(),
                txtPlace.Text.Trim()
                );
            return trophy;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtLeague.Text = "";
            txtCountry.Text = "";
            txtSeason.Text = "";
            txtPlace.Text = "";
            lblInfo.Visible = false;
        }


        //6. Pronaći proizvoljan javni REST API
        private async void btnGetApi_ClickAsync(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api-football-beta.p.rapidapi.com/trophies?player=276"),
                Headers =
                {
                    { "X-RapidAPI-Key", "9ebb09ff61msh1860d6141d0d303p102320jsn0a33561d5907" },
                    { "X-RapidAPI-Host", "api-football-beta.p.rapidapi.com" },
                },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                Trophies trophies = JsonConvert.DeserializeObject<Trophies>(body);
                lbTrophies.Items.Clear();
                foreach (var item in trophies.AllTrophies)
                {
                    lbTrophies.Items.Add(item.ToString());
                }
            }
        }

        private void btnResetList_Click(object sender, EventArgs e)
        {
            lbTrophies.Items.Clear();
        }




        //3. Soap - Search
        private void btnSerach_Click(object sender, EventArgs e)
        {
            lbSearched.Items.Clear();
            lblSearchInfo.Visible = false;
            key = cbNode.SelectedItem.ToString();
            value = txtSearchedValue.Text.Trim();
            SearchTrophy.TrophySearchServiceSoapClient client = new SearchTrophy.TrophySearchServiceSoapClient();
            var result = client.SearchTrophies(key, value);

            if (result.Length != 0)
            {
                foreach (var item in result)
                {
                    Model.Trophy t = new Model.Trophy(
                        item.League,
                        item.Country,
                        item.Season,
                        item.Place);
                    lbSearched.Items.Add(t);
                }
            }
            else
            {
                lblSearchInfo.Visible = true;
                lblSearchInfo.ForeColor = Color.Red;
                lblSearchInfo.Text = "Nothing found! Try another search...";
            }   
        }


        ////////////////// Application Exit //////////////////
        private void btnExit_Click(object sender, EventArgs e) => this.Close();

    }
}
