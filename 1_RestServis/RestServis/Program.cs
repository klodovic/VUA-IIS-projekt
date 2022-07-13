using Newtonsoft.Json;
using RestServis.Models;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
Trophies trophies;
string rawData;

/*
List<Trophy> trophyList = new List<Trophy>
{
    new Trophy{
        League = "Copa America",
        Country = "South-America",
        Season = "2021 Brazil",
        Place = "2nd Place"
    },

    new Trophy{
        League = "Trophée des Champions",
        Country = "France",
        Season = "2021/2022",
        Place = "2nd Place"
    },

    new Trophy{
        League = "Sudamericano U20",
        Country = "South-America",
        Season = "Peru 2011",
        Place = "Winner"
    },

};
*/

//Retrieve data from API
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
    trophies = JsonConvert.DeserializeObject<Trophies>(body);
}


builder.Services.AddControllers().AddXmlDataContractSerializerFormatters();

builder.Services.AddSingleton<Trophies>(trophies);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
