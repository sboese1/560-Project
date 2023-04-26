
namespace _560_Project
{
    partial class Form1
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
            this.updatePlayerStatsButton = new System.Windows.Forms.Button();
            this.addNewPlayerStats = new System.Windows.Forms.Button();
            this.addNewPlayerButton = new System.Windows.Forms.Button();
            this.AddNewTeamButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.playerTotalsButton = new System.Windows.Forms.Button();
            this.dayPointTotalsButton = new System.Windows.Forms.Button();
            this.playerAveragesButton = new System.Windows.Forms.Button();
            this.standingsButton = new System.Windows.Forms.Button();
            this.firstDateTB = new System.Windows.Forms.TextBox();
            this.lastDateTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deletePlayerButton = new System.Windows.Forms.Button();
            this.viewPlayerButton = new System.Windows.Forms.Button();
            this.deleteTeamButton = new System.Windows.Forms.Button();
            this.viewTeamButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updatePlayerStatsButton
            // 
            this.updatePlayerStatsButton.Location = new System.Drawing.Point(12, 192);
            this.updatePlayerStatsButton.Name = "updatePlayerStatsButton";
            this.updatePlayerStatsButton.Size = new System.Drawing.Size(115, 57);
            this.updatePlayerStatsButton.TabIndex = 0;
            this.updatePlayerStatsButton.Text = "Update Player Stats";
            this.updatePlayerStatsButton.UseVisualStyleBackColor = true;
            this.updatePlayerStatsButton.Click += new System.EventHandler(this.updatePlayerStatsButton_Click);
            // 
            // addNewPlayerStats
            // 
            this.addNewPlayerStats.Location = new System.Drawing.Point(12, 255);
            this.addNewPlayerStats.Name = "addNewPlayerStats";
            this.addNewPlayerStats.Size = new System.Drawing.Size(115, 56);
            this.addNewPlayerStats.TabIndex = 1;
            this.addNewPlayerStats.Text = "Add New Player Stats";
            this.addNewPlayerStats.UseVisualStyleBackColor = true;
            this.addNewPlayerStats.Click += new System.EventHandler(this.addNewPlayerStats_Click);
            // 
            // addNewPlayerButton
            // 
            this.addNewPlayerButton.Location = new System.Drawing.Point(12, 66);
            this.addNewPlayerButton.Name = "addNewPlayerButton";
            this.addNewPlayerButton.Size = new System.Drawing.Size(115, 57);
            this.addNewPlayerButton.TabIndex = 2;
            this.addNewPlayerButton.Text = "Add New Player";
            this.addNewPlayerButton.UseVisualStyleBackColor = true;
            this.addNewPlayerButton.Click += new System.EventHandler(this.addNewPlayerButton_Click);
            // 
            // AddNewTeamButton
            // 
            this.AddNewTeamButton.Location = new System.Drawing.Point(12, 317);
            this.AddNewTeamButton.Name = "AddNewTeamButton";
            this.AddNewTeamButton.Size = new System.Drawing.Size(115, 60);
            this.AddNewTeamButton.TabIndex = 3;
            this.AddNewTeamButton.Text = "Add New Team";
            this.AddNewTeamButton.UseVisualStyleBackColor = true;
            this.AddNewTeamButton.Click += new System.EventHandler(this.AddNewTeamButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(279, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(169, 407);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(463, 35);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(169, 407);
            this.listBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Teams";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Players";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(12, 6);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(115, 54);
            this.ConnectButton.TabIndex = 8;
            this.ConnectButton.Text = "Connect To Server";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(674, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(648, 35);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(444, 407);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // playerTotalsButton
            // 
            this.playerTotalsButton.Location = new System.Drawing.Point(148, 383);
            this.playerTotalsButton.Name = "playerTotalsButton";
            this.playerTotalsButton.Size = new System.Drawing.Size(115, 59);
            this.playerTotalsButton.TabIndex = 15;
            this.playerTotalsButton.Text = "Calculate Players\' Totals";
            this.playerTotalsButton.UseVisualStyleBackColor = true;
            this.playerTotalsButton.Click += new System.EventHandler(this.playerTotalsButton_Click);
            // 
            // dayPointTotalsButton
            // 
            this.dayPointTotalsButton.Location = new System.Drawing.Point(148, 317);
            this.dayPointTotalsButton.Name = "dayPointTotalsButton";
            this.dayPointTotalsButton.Size = new System.Drawing.Size(115, 60);
            this.dayPointTotalsButton.TabIndex = 14;
            this.dayPointTotalsButton.Text = "Calculate Day Point Totals";
            this.dayPointTotalsButton.UseVisualStyleBackColor = true;
            this.dayPointTotalsButton.Click += new System.EventHandler(this.dayPointTotalsButton_Click);
            // 
            // playerAveragesButton
            // 
            this.playerAveragesButton.Location = new System.Drawing.Point(148, 255);
            this.playerAveragesButton.Name = "playerAveragesButton";
            this.playerAveragesButton.Size = new System.Drawing.Size(115, 56);
            this.playerAveragesButton.TabIndex = 13;
            this.playerAveragesButton.Text = "Calculate Player Averages";
            this.playerAveragesButton.UseVisualStyleBackColor = true;
            this.playerAveragesButton.Click += new System.EventHandler(this.playerAveragesButton_Click);
            // 
            // standingsButton
            // 
            this.standingsButton.Location = new System.Drawing.Point(148, 192);
            this.standingsButton.Name = "standingsButton";
            this.standingsButton.Size = new System.Drawing.Size(115, 57);
            this.standingsButton.TabIndex = 12;
            this.standingsButton.Text = "Calculate Standings";
            this.standingsButton.UseVisualStyleBackColor = true;
            this.standingsButton.Click += new System.EventHandler(this.standingsButton_Click);
            // 
            // firstDateTB
            // 
            this.firstDateTB.Location = new System.Drawing.Point(78, 455);
            this.firstDateTB.Name = "firstDateTB";
            this.firstDateTB.Size = new System.Drawing.Size(100, 20);
            this.firstDateTB.TabIndex = 16;
            // 
            // lastDateTB
            // 
            this.lastDateTB.Location = new System.Drawing.Point(259, 455);
            this.lastDateTB.Name = "lastDateTB";
            this.lastDateTB.Size = new System.Drawing.Size(100, 20);
            this.lastDateTB.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "First Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Last Date";
            // 
            // deletePlayerButton
            // 
            this.deletePlayerButton.Location = new System.Drawing.Point(12, 129);
            this.deletePlayerButton.Name = "deletePlayerButton";
            this.deletePlayerButton.Size = new System.Drawing.Size(115, 57);
            this.deletePlayerButton.TabIndex = 20;
            this.deletePlayerButton.Text = "Delete Player";
            this.deletePlayerButton.UseVisualStyleBackColor = true;
            this.deletePlayerButton.Click += new System.EventHandler(this.deletePlayerButton_Click);
            // 
            // viewPlayerButton
            // 
            this.viewPlayerButton.Location = new System.Drawing.Point(148, 66);
            this.viewPlayerButton.Name = "viewPlayerButton";
            this.viewPlayerButton.Size = new System.Drawing.Size(115, 57);
            this.viewPlayerButton.TabIndex = 21;
            this.viewPlayerButton.Text = "View Player";
            this.viewPlayerButton.UseVisualStyleBackColor = true;
            this.viewPlayerButton.Click += new System.EventHandler(this.viewPlayerButton_Click);
            // 
            // deleteTeamButton
            // 
            this.deleteTeamButton.Location = new System.Drawing.Point(12, 383);
            this.deleteTeamButton.Name = "deleteTeamButton";
            this.deleteTeamButton.Size = new System.Drawing.Size(115, 59);
            this.deleteTeamButton.TabIndex = 22;
            this.deleteTeamButton.Text = "Delete Team";
            this.deleteTeamButton.UseVisualStyleBackColor = true;
            this.deleteTeamButton.Click += new System.EventHandler(this.deleteTeamButton_Click);
            // 
            // viewTeamButton
            // 
            this.viewTeamButton.Location = new System.Drawing.Point(148, 129);
            this.viewTeamButton.Name = "viewTeamButton";
            this.viewTeamButton.Size = new System.Drawing.Size(115, 57);
            this.viewTeamButton.TabIndex = 23;
            this.viewTeamButton.Text = "View Team";
            this.viewTeamButton.UseVisualStyleBackColor = true;
            this.viewTeamButton.Click += new System.EventHandler(this.viewTeamButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(848, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 487);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.viewTeamButton);
            this.Controls.Add(this.deleteTeamButton);
            this.Controls.Add(this.viewPlayerButton);
            this.Controls.Add(this.deletePlayerButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastDateTB);
            this.Controls.Add(this.firstDateTB);
            this.Controls.Add(this.playerTotalsButton);
            this.Controls.Add(this.dayPointTotalsButton);
            this.Controls.Add(this.playerAveragesButton);
            this.Controls.Add(this.standingsButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.AddNewTeamButton);
            this.Controls.Add(this.addNewPlayerButton);
            this.Controls.Add(this.addNewPlayerStats);
            this.Controls.Add(this.updatePlayerStatsButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updatePlayerStatsButton;
        private System.Windows.Forms.Button addNewPlayerStats;
        private System.Windows.Forms.Button addNewPlayerButton;
        private System.Windows.Forms.Button AddNewTeamButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button playerTotalsButton;
        private System.Windows.Forms.Button dayPointTotalsButton;
        private System.Windows.Forms.Button playerAveragesButton;
        private System.Windows.Forms.Button standingsButton;
        private System.Windows.Forms.TextBox firstDateTB;
        private System.Windows.Forms.TextBox lastDateTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deletePlayerButton;
        private System.Windows.Forms.Button viewPlayerButton;
        private System.Windows.Forms.Button deleteTeamButton;
        private System.Windows.Forms.Button viewTeamButton;
        private System.Windows.Forms.Label label6;
    }
}

