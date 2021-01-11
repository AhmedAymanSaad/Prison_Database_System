namespace PrisonDBApp
{
    partial class Civ_ViewBoard
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
            this.UpdateInfoButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.UpdatePWButton = new System.Windows.Forms.Button();
            this.RegisterVisitorButton = new System.Windows.Forms.Button();
            this.CheckPersonStatusButton = new System.Windows.Forms.Button();
            this.CheckSentButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpdateInfoButton
            // 
            this.UpdateInfoButton.Location = new System.Drawing.Point(12, 95);
            this.UpdateInfoButton.Name = "UpdateInfoButton";
            this.UpdateInfoButton.Size = new System.Drawing.Size(112, 45);
            this.UpdateInfoButton.TabIndex = 1;
            this.UpdateInfoButton.Text = "Update Info";
            this.UpdateInfoButton.UseVisualStyleBackColor = true;
            this.UpdateInfoButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Manage Visits";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // UpdatePWButton
            // 
            this.UpdatePWButton.Location = new System.Drawing.Point(12, 163);
            this.UpdatePWButton.Name = "UpdatePWButton";
            this.UpdatePWButton.Size = new System.Drawing.Size(112, 52);
            this.UpdatePWButton.TabIndex = 3;
            this.UpdatePWButton.Text = "Change password";
            this.UpdatePWButton.UseVisualStyleBackColor = true;
            this.UpdatePWButton.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // RegisterVisitorButton
            // 
            this.RegisterVisitorButton.Location = new System.Drawing.Point(12, 22);
            this.RegisterVisitorButton.Name = "RegisterVisitorButton";
            this.RegisterVisitorButton.Size = new System.Drawing.Size(117, 45);
            this.RegisterVisitorButton.TabIndex = 4;
            this.RegisterVisitorButton.Text = "Register as a Visitor";
            this.RegisterVisitorButton.UseVisualStyleBackColor = true;
            this.RegisterVisitorButton.Click += new System.EventHandler(this.RegisterVisitorButton_Click);
            // 
            // CheckPersonStatusButton
            // 
            this.CheckPersonStatusButton.Location = new System.Drawing.Point(178, 95);
            this.CheckPersonStatusButton.Name = "CheckPersonStatusButton";
            this.CheckPersonStatusButton.Size = new System.Drawing.Size(117, 45);
            this.CheckPersonStatusButton.TabIndex = 5;
            this.CheckPersonStatusButton.Text = "Check person status";
            this.CheckPersonStatusButton.UseVisualStyleBackColor = true;
            this.CheckPersonStatusButton.Click += new System.EventHandler(this.CheckPersonStatusButton_Click);
            // 
            // CheckSentButton
            // 
            this.CheckSentButton.Location = new System.Drawing.Point(183, 170);
            this.CheckSentButton.Name = "CheckSentButton";
            this.CheckSentButton.Size = new System.Drawing.Size(112, 45);
            this.CheckSentButton.TabIndex = 6;
            this.CheckSentButton.Text = "Check Sentence";
            this.CheckSentButton.UseVisualStyleBackColor = false;
            this.CheckSentButton.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.DarkGreen;
            this.button1.Location = new System.Drawing.Point(324, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // Civ_ViewBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 250);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CheckSentButton);
            this.Controls.Add(this.CheckPersonStatusButton);
            this.Controls.Add(this.RegisterVisitorButton);
            this.Controls.Add(this.UpdatePWButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UpdateInfoButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Civ_ViewBoard";
            this.Text = "Civilian Log In";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button UpdateInfoButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button UpdatePWButton;
        private System.Windows.Forms.Button RegisterVisitorButton;
        private System.Windows.Forms.Button CheckPersonStatusButton;
        private System.Windows.Forms.Button CheckSentButton;
        private System.Windows.Forms.Button button1;
    }
}