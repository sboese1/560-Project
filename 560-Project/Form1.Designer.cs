
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ViewTeamScheduleButton
            // 
            this.ViewTeamScheduleButton.Location = new System.Drawing.Point(107, 115);
            this.ViewTeamScheduleButton.Name = "ViewTeamScheduleButton";
            this.ViewTeamScheduleButton.Size = new System.Drawing.Size(115, 57);
            this.ViewTeamScheduleButton.TabIndex = 0;
            this.ViewTeamScheduleButton.Text = "View Team Schedule";
            this.ViewTeamScheduleButton.UseVisualStyleBackColor = true;
            // 
            // ViewTeamStatsButton
            // 
            this.ViewTeamStatsButton.Location = new System.Drawing.Point(107, 191);
            this.ViewTeamStatsButton.Name = "ViewTeamStatsButton";
            this.ViewTeamStatsButton.Size = new System.Drawing.Size(115, 56);
            this.ViewTeamStatsButton.TabIndex = 1;
            this.ViewTeamStatsButton.Text = "View Team Stats";
            this.ViewTeamStatsButton.UseVisualStyleBackColor = true;
            this.ViewTeamStatsButton.Click += new System.EventHandler(this.ViewTeamStatsButton_Click);
            // 
            // ViewPlayerStatsButton
            // 
            this.ViewPlayerStatsButton.Location = new System.Drawing.Point(107, 267);
            this.ViewPlayerStatsButton.Name = "ViewPlayerStatsButton";
            this.ViewPlayerStatsButton.Size = new System.Drawing.Size(115, 60);
            this.ViewPlayerStatsButton.TabIndex = 2;
            this.ViewPlayerStatsButton.Text = "View Player Stats";
            this.ViewPlayerStatsButton.UseVisualStyleBackColor = true;
            this.ViewPlayerStatsButton.Click += new System.EventHandler(this.ViewPlayerStatsButton_Click);
            // 
            // AddNewTeamButton
            // 
            this.AddNewTeamButton.Location = new System.Drawing.Point(107, 344);
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
            this.listBox1.Location = new System.Drawing.Point(263, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(169, 342);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(438, 61);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(169, 342);
            this.listBox2.TabIndex = 5;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Teams";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Players";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(107, 42);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(115, 54);
            this.ConnectButton.TabIndex = 8;
            this.ConnectButton.Text = "Connect To Server";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(619, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(169, 342);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(689, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label3;
    }
}

