namespace PrisonDBApp
{
    partial class CivChangePassword
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
            this.UpdatePassOldTextbox = new System.Windows.Forms.TextBox();
            this.UpdatePassNewTextbox = new System.Windows.Forms.TextBox();
            this.RepeatUpdatetextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpdatePassOldTextbox
            // 
            this.UpdatePassOldTextbox.Location = new System.Drawing.Point(123, 30);
            this.UpdatePassOldTextbox.Name = "UpdatePassOldTextbox";
            this.UpdatePassOldTextbox.PasswordChar = '*';
            this.UpdatePassOldTextbox.Size = new System.Drawing.Size(100, 20);
            this.UpdatePassOldTextbox.TabIndex = 0;
            this.UpdatePassOldTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UpdatePassOldTextbox_KeyPress);
            // 
            // UpdatePassNewTextbox
            // 
            this.UpdatePassNewTextbox.Location = new System.Drawing.Point(123, 108);
            this.UpdatePassNewTextbox.Name = "UpdatePassNewTextbox";
            this.UpdatePassNewTextbox.PasswordChar = '*';
            this.UpdatePassNewTextbox.Size = new System.Drawing.Size(100, 20);
            this.UpdatePassNewTextbox.TabIndex = 1;
            this.UpdatePassNewTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UpdatePassNewTextbox_KeyPress);
            // 
            // RepeatUpdatetextbox
            // 
            this.RepeatUpdatetextbox.Location = new System.Drawing.Point(123, 180);
            this.RepeatUpdatetextbox.Name = "RepeatUpdatetextbox";
            this.RepeatUpdatetextbox.PasswordChar = '*';
            this.RepeatUpdatetextbox.Size = new System.Drawing.Size(100, 20);
            this.RepeatUpdatetextbox.TabIndex = 2;
            this.RepeatUpdatetextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RepeatUpdatetextbox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Old password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "New password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Repeat new password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CivChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 254);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RepeatUpdatetextbox);
            this.Controls.Add(this.UpdatePassNewTextbox);
            this.Controls.Add(this.UpdatePassOldTextbox);
            this.Name = "CivChangePassword";
            this.Text = "Change password";
            this.Load += new System.EventHandler(this.CivChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UpdatePassOldTextbox;
        private System.Windows.Forms.TextBox UpdatePassNewTextbox;
        private System.Windows.Forms.TextBox RepeatUpdatetextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}