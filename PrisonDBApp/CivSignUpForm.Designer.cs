namespace PrisonDBApp
{
    partial class CivSignUpForm
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
            this.CivSignUpText = new System.Windows.Forms.TextBox();
            this.CivPasswordtext = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Civpasswordrepeattext = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Create_Civ_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CivSignUpText
            // 
            this.CivSignUpText.Location = new System.Drawing.Point(134, 46);
            this.CivSignUpText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CivSignUpText.Name = "CivSignUpText";
            this.CivSignUpText.Size = new System.Drawing.Size(101, 20);
            this.CivSignUpText.TabIndex = 0;
            this.CivSignUpText.TextChanged += new System.EventHandler(this.CivSignUpText_TextChanged);
            // 
            // CivPasswordtext
            // 
            this.CivPasswordtext.Location = new System.Drawing.Point(134, 106);
            this.CivPasswordtext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CivPasswordtext.Name = "CivPasswordtext";
            this.CivPasswordtext.PasswordChar = '*';
            this.CivPasswordtext.Size = new System.Drawing.Size(101, 20);
            this.CivPasswordtext.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Repeat Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(262, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Required*";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(262, 176);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Required*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(262, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Required*";
            // 
            // Civpasswordrepeattext
            // 
            this.Civpasswordrepeattext.Location = new System.Drawing.Point(134, 171);
            this.Civpasswordrepeattext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Civpasswordrepeattext.Name = "Civpasswordrepeattext";
            this.Civpasswordrepeattext.PasswordChar = '*';
            this.Civpasswordrepeattext.Size = new System.Drawing.Size(101, 20);
            this.Civpasswordrepeattext.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(450, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Please enter the password and username as numbers without characters or special c" +
    "haracters";
            // 
            // Create_Civ_Button
            // 
            this.Create_Civ_Button.Location = new System.Drawing.Point(178, 256);
            this.Create_Civ_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Create_Civ_Button.Name = "Create_Civ_Button";
            this.Create_Civ_Button.Size = new System.Drawing.Size(94, 21);
            this.Create_Civ_Button.TabIndex = 11;
            this.Create_Civ_Button.Text = "Create Account";
            this.Create_Civ_Button.UseVisualStyleBackColor = true;
            this.Create_Civ_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CivSignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 317);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Create_Civ_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Civpasswordrepeattext);
            this.Controls.Add(this.CivPasswordtext);
            this.Controls.Add(this.CivSignUpText);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CivSignUpForm";
            this.Text = "CivSignUpForm";
            this.Load += new System.EventHandler(this.CivSignUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CivSignUpText;
        private System.Windows.Forms.MaskedTextBox CivPasswordtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox Civpasswordrepeattext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Create_Civ_Button;
        private System.Windows.Forms.Button button1;
    }
}