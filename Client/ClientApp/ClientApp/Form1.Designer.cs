
namespace ClientApp
{
    partial class Trophy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trophy));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.addTrophy = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbRNG = new System.Windows.Forms.RadioButton();
            this.rbXSD = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSeason = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLeague = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTrophies = new System.Windows.Forms.ListBox();
            this.btnGetApi = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblSearchInfo = new System.Windows.Forms.Label();
            this.btnSerach = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearchedValue = new System.Windows.Forms.TextBox();
            this.lbSearched = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbNode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnResetList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.lblInfo);
            this.groupBox1.Controls.Add(this.addTrophy);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPlace);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSeason);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCountry);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLeague);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 951);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "XSD - RNG Validation";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReset.ForeColor = System.Drawing.Color.Firebrick;
            this.btnReset.Location = new System.Drawing.Point(242, 460);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(117, 53);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInfo.Location = new System.Drawing.Point(18, 549);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 20);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Visible = false;
            // 
            // addTrophy
            // 
            this.addTrophy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addTrophy.ForeColor = System.Drawing.Color.DarkCyan;
            this.addTrophy.Location = new System.Drawing.Point(21, 460);
            this.addTrophy.Name = "addTrophy";
            this.addTrophy.Size = new System.Drawing.Size(205, 53);
            this.addTrophy.TabIndex = 4;
            this.addTrophy.Text = "Add New Trophy";
            this.addTrophy.UseVisualStyleBackColor = true;
            this.addTrophy.Click += new System.EventHandler(this.addTrophy_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbRNG);
            this.groupBox3.Controls.Add(this.rbXSD);
            this.groupBox3.Location = new System.Drawing.Point(21, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 100);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "XSD or RNG Validation";
            // 
            // rbRNG
            // 
            this.rbRNG.AutoSize = true;
            this.rbRNG.Location = new System.Drawing.Point(205, 43);
            this.rbRNG.Name = "rbRNG";
            this.rbRNG.Size = new System.Drawing.Size(58, 20);
            this.rbRNG.TabIndex = 1;
            this.rbRNG.Text = "RNG";
            this.rbRNG.UseVisualStyleBackColor = true;
            // 
            // rbXSD
            // 
            this.rbXSD.AutoSize = true;
            this.rbXSD.Checked = true;
            this.rbXSD.Location = new System.Drawing.Point(60, 43);
            this.rbXSD.Name = "rbXSD";
            this.rbXSD.Size = new System.Drawing.Size(55, 20);
            this.rbXSD.TabIndex = 0;
            this.rbXSD.TabStop = true;
            this.rbXSD.Text = "XSD";
            this.rbXSD.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Place";
            // 
            // txtPlace
            // 
            this.txtPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPlace.Location = new System.Drawing.Point(21, 286);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(338, 29);
            this.txtPlace.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Season";
            // 
            // txtSeason
            // 
            this.txtSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSeason.Location = new System.Drawing.Point(23, 215);
            this.txtSeason.Name = "txtSeason";
            this.txtSeason.Size = new System.Drawing.Size(338, 29);
            this.txtSeason.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Counrty";
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCountry.Location = new System.Drawing.Point(23, 144);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(338, 29);
            this.txtCountry.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "League";
            // 
            // txtLeague
            // 
            this.txtLeague.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLeague.Location = new System.Drawing.Point(23, 73);
            this.txtLeague.Name = "txtLeague";
            this.txtLeague.Size = new System.Drawing.Size(338, 29);
            this.txtLeague.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnResetList);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbTrophies);
            this.groupBox2.Controls.Add(this.btnGetApi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(399, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 951);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RestApi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(133, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Get all available trophies for a player or a coach";
            // 
            // lbTrophies
            // 
            this.lbTrophies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTrophies.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbTrophies.FormattingEnabled = true;
            this.lbTrophies.ItemHeight = 15;
            this.lbTrophies.Location = new System.Drawing.Point(5, 74);
            this.lbTrophies.Name = "lbTrophies";
            this.lbTrophies.Size = new System.Drawing.Size(646, 769);
            this.lbTrophies.TabIndex = 2;
            // 
            // btnGetApi
            // 
            this.btnGetApi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGetApi.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnGetApi.Location = new System.Drawing.Point(147, 874);
            this.btnGetApi.Name = "btnGetApi";
            this.btnGetApi.Size = new System.Drawing.Size(255, 53);
            this.btnGetApi.TabIndex = 1;
            this.btnGetApi.Text = "Get Trophies";
            this.btnGetApi.UseVisualStyleBackColor = true;
            this.btnGetApi.Click += new System.EventHandler(this.btnGetApi_ClickAsync);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cbNode);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.lbSearched);
            this.groupBox4.Controls.Add(this.lblSearchInfo);
            this.groupBox4.Controls.Add(this.btnSerach);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtSearchedValue);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(1063, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(625, 951);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Soap";
            // 
            // lblSearchInfo
            // 
            this.lblSearchInfo.AutoSize = true;
            this.lblSearchInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSearchInfo.Location = new System.Drawing.Point(10, 922);
            this.lblSearchInfo.Name = "lblSearchInfo";
            this.lblSearchInfo.Size = new System.Drawing.Size(0, 20);
            this.lblSearchInfo.TabIndex = 9;
            this.lblSearchInfo.Visible = false;
            // 
            // btnSerach
            // 
            this.btnSerach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSerach.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnSerach.Location = new System.Drawing.Point(516, 874);
            this.btnSerach.Name = "btnSerach";
            this.btnSerach.Size = new System.Drawing.Size(103, 35);
            this.btnSerach.TabIndex = 4;
            this.btnSerach.Text = "Search";
            this.btnSerach.UseVisualStyleBackColor = true;
            this.btnSerach.Click += new System.EventHandler(this.btnSerach_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(158, 854);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Input value to search";
            // 
            // txtSearchedValue
            // 
            this.txtSearchedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSearchedValue.Location = new System.Drawing.Point(160, 874);
            this.txtSearchedValue.Name = "txtSearchedValue";
            this.txtSearchedValue.Size = new System.Drawing.Size(350, 34);
            this.txtSearchedValue.TabIndex = 0;
            // 
            // lbSearched
            // 
            this.lbSearched.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbSearched.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbSearched.FormattingEnabled = true;
            this.lbSearched.ItemHeight = 15;
            this.lbSearched.Location = new System.Drawing.Point(6, 73);
            this.lbSearched.Name = "lbSearched";
            this.lbSearched.Size = new System.Drawing.Size(613, 769);
            this.lbSearched.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(231, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Search for trophies";
            // 
            // cbNode
            // 
            this.cbNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbNode.FormattingEnabled = true;
            this.cbNode.Location = new System.Drawing.Point(7, 874);
            this.cbNode.Name = "cbNode";
            this.cbNode.Size = new System.Drawing.Size(147, 33);
            this.cbNode.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 855);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Select an Option";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnExit.Location = new System.Drawing.Point(1532, 969);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(156, 53);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit application";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnResetList
            // 
            this.btnResetList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnResetList.ForeColor = System.Drawing.Color.Firebrick;
            this.btnResetList.Location = new System.Drawing.Point(408, 874);
            this.btnResetList.Name = "btnResetList";
            this.btnResetList.Size = new System.Drawing.Size(117, 53);
            this.btnResetList.TabIndex = 12;
            this.btnResetList.Text = "Reset";
            this.btnResetList.UseVisualStyleBackColor = true;
            this.btnResetList.Click += new System.EventHandler(this.btnResetList_Click);
            // 
            // Trophy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 1033);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Trophy";
            this.Text = "Trophy";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGetApi;
        private System.Windows.Forms.ListBox lbTrophies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLeague;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSeason;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button addTrophy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbRNG;
        private System.Windows.Forms.RadioButton rbXSD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblSearchInfo;
        private System.Windows.Forms.Button btnSerach;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearchedValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbSearched;
        private System.Windows.Forms.ComboBox cbNode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnResetList;
    }
}

