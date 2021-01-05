namespace PrisonDBApp
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
            this.SuspendLayout();
            // 
            // Form_for_HiringAndFiring_Button
            // 
            this.Form_for_HiringAndFiring_Button.Location = new System.Drawing.Point(47, 27);
            this.Form_for_HiringAndFiring_Button.Name = "Form_for_HiringAndFiring_Button";
            this.Form_for_HiringAndFiring_Button.Size = new System.Drawing.Size(163, 38);
            this.Form_for_HiringAndFiring_Button.TabIndex = 0;
            this.Form_for_HiringAndFiring_Button.Text = "Hire/Fire Guards";
            this.Form_for_HiringAndFiring_Button.UseVisualStyleBackColor = true;
            this.Form_for_HiringAndFiring_Button.Click += new System.EventHandler(this.Form_for_HiringAndFiring_Button_Click);
            // 
            // Cells_Button
            // 
            this.Cells_Button.Location = new System.Drawing.Point(47, 95);
            this.Cells_Button.Name = "Cells_Button";
            this.Cells_Button.Size = new System.Drawing.Size(163, 42);
            this.Cells_Button.TabIndex = 1;
            this.Cells_Button.Text = "Repairs";
            this.Cells_Button.UseVisualStyleBackColor = true;
            this.Cells_Button.Click += new System.EventHandler(this.Cells_Button_Click);
            // 
            // Inmate_Button
            // 
            this.Inmate_Button.Location = new System.Drawing.Point(47, 172);
            this.Inmate_Button.Name = "Inmate_Button";
            this.Inmate_Button.Size = new System.Drawing.Size(163, 46);
            this.Inmate_Button.TabIndex = 2;
            this.Inmate_Button.Text = "Inmates";
            this.Inmate_Button.UseVisualStyleBackColor = true;
            this.Inmate_Button.Click += new System.EventHandler(this.Inmate_Button_Click);
            // 
            // PrisonWarden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Inmate_Button);
            this.Controls.Add(this.Cells_Button);
            this.Controls.Add(this.Form_for_HiringAndFiring_Button);
            this.Name = "PrisonWarden";
            this.Text = "PrisonWarden";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Form_for_HiringAndFiring_Button;
        private System.Windows.Forms.Button Cells_Button;
        private System.Windows.Forms.Button Inmate_Button;
    }
}