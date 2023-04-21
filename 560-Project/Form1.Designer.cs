
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
            this.ViewTeamScheduleButton = new System.Windows.Forms.Button();
            this.ViewTeamStatsButton = new System.Windows.Forms.Button();
            this.ViewPlayerStatsButton = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // ViewTeamScheduleButton
            // 
            this.ViewTeamScheduleButton.Location = new System.Drawing.Point(12, 92);
            this.ViewTeamScheduleButton.Name = "ViewTeamScheduleButton";
            this.ViewTeamScheduleButton.Size = new System.Drawing.Size(115, 57);
            this.ViewTeamScheduleButton.TabIndex = 0;
            this.ViewTeamScheduleButton.Text = "View Team Schedule";
            this.ViewTeamScheduleButton.UseVisualStyleBackColor = true;
            // 
            // ViewTeamStatsButton
            // 
            this.ViewTeamStatsButton.Location = new System.Drawing.Point(12, 187);
            this.ViewTeamStatsButton.Name = "ViewTeamStatsButton";
            this.ViewTeamStatsButton.Size = new System.Drawing.Size(115, 56);
            this.ViewTeamStatsButton.TabIndex = 1;
            this.ViewTeamStatsButton.Text = "View Team Stats";
            this.ViewTeamStatsButton.UseVisualStyleBackColor = true;
            this.ViewTeamStatsButton.Click += new System.EventHandler(this.ViewTeamStatsButton_Click);
            // 
            // ViewPlayerStatsButton
            // 
            this.ViewPlayerStatsButton.Location = new System.Drawing.Point(12, 286);
            this.ViewPlayerStatsButton.Name = "ViewPlayerStatsButton";
            this.ViewPlayerStatsButton.Size = new System.Drawing.Size(115, 60);
            this.ViewPlayerStatsButton.TabIndex = 2;
            this.ViewPlayerStatsButton.Text = "View Player Stats";
            this.ViewPlayerStatsButton.UseVisualStyleBackColor = true;
            this.ViewPlayerStatsButton.Click += new System.EventHandler(this.ViewPlayerStatsButton_Click);
            // 
            // AddNewTeamButton
            // 
            this.AddNewTeamButton.Location = new System.Drawing.Point(12, 383);
            this.AddNewTeamButton.Name = "AddNewTeamButton";
            this.AddNewTeamButton.Size = new System.Drawing.Size(115, 59);
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
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
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
            this.ConnectButton.Location = new System.Drawing.Point(78, 19);
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
            this.playerTotalsButton.Text = "Calculate Player Totals";
            this.playerTotalsButton.UseVisualStyleBackColor = true;
            this.playerTotalsButton.Click += new System.EventHandler(this.playerTotalsButton_Click);
            // 
            // dayPointTotalsButton
            // 
            this.dayPointTotalsButton.Location = new System.Drawing.Point(148, 286);
            this.dayPointTotalsButton.Name = "dayPointTotalsButton";
            this.dayPointTotalsButton.Size = new System.Drawing.Size(115, 60);
            this.dayPointTotalsButton.TabIndex = 14;
            this.dayPointTotalsButton.Text = "Calculate Day Point Totals";
            this.dayPointTotalsButton.UseVisualStyleBackColor = true;
            this.dayPointTotalsButton.Click += new System.EventHandler(this.dayPointTotalsButton_Click);
            // 
            // playerAveragesButton
            // 
            this.playerAveragesButton.Location = new System.Drawing.Point(148, 187);
            this.playerAveragesButton.Name = "playerAveragesButton";
            this.playerAveragesButton.Size = new System.Drawing.Size(115, 56);
            this.playerAveragesButton.TabIndex = 13;
            this.playerAveragesButton.Text = "Calculate Player Averages";
            this.playerAveragesButton.UseVisualStyleBackColor = true;
            this.playerAveragesButton.Click += new System.EventHandler(this.playerAveragesButton_Click);
            // 
            // standingsButton
            // 
            this.standingsButton.Location = new System.Drawing.Point(148, 92);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 487);
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
            this.Controls.Add(this.ViewPlayerStatsButton);
            this.Controls.Add(this.ViewTeamStatsButton);
            this.Controls.Add(this.ViewTeamScheduleButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ViewTeamScheduleButton;
        private System.Windows.Forms.Button ViewTeamStatsButton;
        private System.Windows.Forms.Button ViewPlayerStatsButton;
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
    }
}

