namespace PrisonDBApp
{
    partial class CivRegisterVisitorFormcs
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
            this.components = new System.ComponentModel.Container();
            this.FnameRegTextbox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NatIDRegTextbox = new System.Windows.Forms.TextBox();
            this.PhoneNumbRegTextBox = new System.Windows.Forms.TextBox();
            this.MinitRegTextbox = new System.Windows.Forms.TextBox();
            this.LnameRegTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RegisterAsVisitorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FnameRegTextbox
            // 
            this.FnameRegTextbox.Location = new System.Drawing.Point(75, 37);
            this.FnameRegTextbox.Name = "FnameRegTextbox";
            this.FnameRegTextbox.Size = new System.Drawing.Size(100, 20);
            this.FnameRegTextbox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // NatIDRegTextbox
            // 
            this.NatIDRegTextbox.Location = new System.Drawing.Point(75, 112);
            this.NatIDRegTextbox.Name = "NatIDRegTextbox";
            this.NatIDRegTextbox.Size = new System.Drawing.Size(100, 20);
            this.NatIDRegTextbox.TabIndex = 2;
            // 
            // PhoneNumbRegTextBox
            // 
            this.PhoneNumbRegTextBox.Location = new System.Drawing.Point(261, 112);
            this.PhoneNumbRegTextBox.Name = "PhoneNumbRegTextBox";
            this.PhoneNumbRegTextBox.Size = new System.Drawing.Size(100, 20);
            this.PhoneNumbRegTextBox.TabIndex = 4;
            // 
            // MinitRegTextbox
            // 
            this.MinitRegTextbox.Location = new System.Drawing.Point(261, 37);
            this.MinitRegTextbox.Name = "MinitRegTextbox";
            this.MinitRegTextbox.Size = new System.Drawing.Size(100, 20);
            this.MinitRegTextbox.TabIndex = 3;
            // 
            // LnameRegTextbox
            // 
            this.LnameRegTextbox.Location = new System.Drawing.Point(445, 37);
            this.LnameRegTextbox.Name = "LnameRegTextbox";
            this.LnameRegTextbox.Size = new System.Drawing.Size(100, 20);
            this.LnameRegTextbox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "NationalID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Middle initial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phone#";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Last name";
            // 
            // RegisterAsVisitorButton
            // 
            this.RegisterAsVisitorButton.Location = new System.Drawing.Point(445, 110);
            this.RegisterAsVisitorButton.Name = "RegisterAsVisitorButton";
            this.RegisterAsVisitorButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterAsVisitorButton.TabIndex = 12;
            this.RegisterAsVisitorButton.Text = "Register";
            this.RegisterAsVisitorButton.UseVisualStyleBackColor = true;
            this.RegisterAsVisitorButton.Click += new System.EventHandler(this.RegisterAsVisitorButton_Click);
            // 
            // CivRegisterVisitorFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 242);
            this.Controls.Add(this.RegisterAsVisitorButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LnameRegTextbox);
            this.Controls.Add(this.PhoneNumbRegTextBox);
            this.Controls.Add(this.MinitRegTextbox);
            this.Controls.Add(this.NatIDRegTextbox);
            this.Controls.Add(this.FnameRegTextbox);
            this.Name = "CivRegisterVisitorFormcs";
            this.Text = "CivRegisterVisitorFormcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FnameRegTextbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox NatIDRegTextbox;
        private System.Windows.Forms.TextBox PhoneNumbRegTextBox;
        private System.Windows.Forms.TextBox MinitRegTextbox;
        private System.Windows.Forms.TextBox LnameRegTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RegisterAsVisitorButton;
    }
}