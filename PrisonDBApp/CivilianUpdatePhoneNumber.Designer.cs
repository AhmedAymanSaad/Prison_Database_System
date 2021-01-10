namespace PrisonDBApp
{
    partial class InfoUpdateForm
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
            this.UpdatePhoneTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PhoneUpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpdatePhoneTextBox
            // 
            this.UpdatePhoneTextBox.Location = new System.Drawing.Point(87, 21);
            this.UpdatePhoneTextBox.Name = "UpdatePhoneTextBox";
            this.UpdatePhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.UpdatePhoneTextBox.TabIndex = 0;
            this.UpdatePhoneTextBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Phone#";
            // 
            // PhoneUpdateButton
            // 
            this.PhoneUpdateButton.Location = new System.Drawing.Point(87, 67);
            this.PhoneUpdateButton.Name = "PhoneUpdateButton";
            this.PhoneUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.PhoneUpdateButton.TabIndex = 2;
            this.PhoneUpdateButton.Text = "Update";
            this.PhoneUpdateButton.UseVisualStyleBackColor = true;
            this.PhoneUpdateButton.Click += new System.EventHandler(this.PhoneUpdateButton_Click);
            // 
            // InfoUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 237);
            this.Controls.Add(this.PhoneUpdateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdatePhoneTextBox);
            this.Name = "InfoUpdateForm";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UpdatePhoneTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PhoneUpdateButton;
    }
}