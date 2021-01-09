namespace PrisonDBApp
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
            this.Prison_Warden_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Prison_Warden_button
            // 
            this.Prison_Warden_button.Location = new System.Drawing.Point(93, 37);
            this.Prison_Warden_button.Name = "Prison_Warden_button";
            this.Prison_Warden_button.Size = new System.Drawing.Size(204, 38);
            this.Prison_Warden_button.TabIndex = 0;
            this.Prison_Warden_button.Text = "Prison Warden view";
            this.Prison_Warden_button.UseVisualStyleBackColor = true;
            this.Prison_Warden_button.Click += new System.EventHandler(this.Prison_Warden_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Guard View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Prison_Warden_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Prison_Warden_button;
        private System.Windows.Forms.Button button1;
    }
}

