namespace _560_Project
{
    partial class AddTeam
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
            this.firstLabel = new System.Windows.Forms.Label();
            this.firstTextbox = new System.Windows.Forms.TextBox();
            this.secondTextbox = new System.Windows.Forms.TextBox();
            this.secondLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Location = new System.Drawing.Point(21, 28);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(65, 13);
            this.firstLabel.TabIndex = 0;
            this.firstLabel.Text = "Team Name";
            // 
            // firstTextbox
            // 
            this.firstTextbox.Location = new System.Drawing.Point(88, 25);
            this.firstTextbox.Name = "firstTextbox";
            this.firstTextbox.Size = new System.Drawing.Size(120, 20);
            this.firstTextbox.TabIndex = 1;
            // 
            // secondTextbox
            // 
            this.secondTextbox.Location = new System.Drawing.Point(88, 62);
            this.secondTextbox.Name = "secondTextbox";
            this.secondTextbox.Size = new System.Drawing.Size(120, 20);
            this.secondTextbox.TabIndex = 3;
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.Location = new System.Drawing.Point(21, 65);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(61, 13);
            this.secondLabel.TabIndex = 2;
            this.secondLabel.Text = "Team Color";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 161);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.secondTextbox);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.firstTextbox);
            this.Controls.Add(this.firstLabel);
            this.Name = "AddTeam";
            this.Text = "AddTeam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.TextBox firstTextbox;
        private System.Windows.Forms.TextBox secondTextbox;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Button button1;
    }
}