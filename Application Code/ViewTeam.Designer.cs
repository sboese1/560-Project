namespace _560_Project
{
    partial class ViewTeam
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
            this.label1 = new System.Windows.Forms.Label();
            this.teamNameTB = new System.Windows.Forms.TextBox();
            this.teamColorTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team Name";
            // 
            // teamNameTB
            // 
            this.teamNameTB.Location = new System.Drawing.Point(83, 17);
            this.teamNameTB.Name = "teamNameTB";
            this.teamNameTB.Size = new System.Drawing.Size(100, 20);
            this.teamNameTB.TabIndex = 1;
            // 
            // teamColorTB
            // 
            this.teamColorTB.Location = new System.Drawing.Point(83, 53);
            this.teamColorTB.Name = "teamColorTB";
            this.teamColorTB.Size = new System.Drawing.Size(100, 20);
            this.teamColorTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Team Color";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 130);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.teamColorTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teamNameTB);
            this.Controls.Add(this.label1);
            this.Name = "ViewTeam";
            this.Text = "ViewTeam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teamNameTB;
        private System.Windows.Forms.TextBox teamColorTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}