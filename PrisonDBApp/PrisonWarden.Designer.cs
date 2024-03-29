﻿namespace PrisonDBApp
{
    partial class PrisonWarden
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
            this.Form_for_HiringAndFiring_Button = new System.Windows.Forms.Button();
            this.Cells_Button = new System.Windows.Forms.Button();
            this.Inmate_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Form_for_HiringAndFiring_Button
            // 
            this.Form_for_HiringAndFiring_Button.Location = new System.Drawing.Point(186, 72);
            this.Form_for_HiringAndFiring_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Form_for_HiringAndFiring_Button.Name = "Form_for_HiringAndFiring_Button";
            this.Form_for_HiringAndFiring_Button.Size = new System.Drawing.Size(122, 44);
            this.Form_for_HiringAndFiring_Button.TabIndex = 0;
            this.Form_for_HiringAndFiring_Button.Text = "Hire/Fire Guards";
            this.Form_for_HiringAndFiring_Button.UseVisualStyleBackColor = true;
            this.Form_for_HiringAndFiring_Button.Click += new System.EventHandler(this.Form_for_HiringAndFiring_Button_Click);
            // 
            // Cells_Button
            // 
            this.Cells_Button.Location = new System.Drawing.Point(29, 72);
            this.Cells_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Cells_Button.Name = "Cells_Button";
            this.Cells_Button.Size = new System.Drawing.Size(128, 47);
            this.Cells_Button.TabIndex = 1;
            this.Cells_Button.Text = "Repairs";
            this.Cells_Button.UseVisualStyleBackColor = true;
            this.Cells_Button.Click += new System.EventHandler(this.Cells_Button_Click);
            // 
            // Inmate_Button
            // 
            this.Inmate_Button.Location = new System.Drawing.Point(186, 171);
            this.Inmate_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Inmate_Button.Name = "Inmate_Button";
            this.Inmate_Button.Size = new System.Drawing.Size(122, 48);
            this.Inmate_Button.TabIndex = 2;
            this.Inmate_Button.Text = "Inmates";
            this.Inmate_Button.UseVisualStyleBackColor = true;
            this.Inmate_Button.Click += new System.EventHandler(this.Inmate_Button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 171);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Visits";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.DarkGreen;
            this.button2.Location = new System.Drawing.Point(340, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 48);
            this.button2.TabIndex = 8;
            this.button2.Text = "Log Out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PrisonWarden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 269);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Inmate_Button);
            this.Controls.Add(this.Cells_Button);
            this.Controls.Add(this.Form_for_HiringAndFiring_Button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PrisonWarden";
            this.Text = "PrisonWarden";
            this.Load += new System.EventHandler(this.PrisonWarden_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Form_for_HiringAndFiring_Button;
        private System.Windows.Forms.Button Cells_Button;
        private System.Windows.Forms.Button Inmate_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}