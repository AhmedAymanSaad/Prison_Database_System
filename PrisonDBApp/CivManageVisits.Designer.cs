namespace PrisonDBApp
{
    partial class VisitForm
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
            this.StartDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.EndDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.VisitInmateTextbox = new System.Windows.Forms.TextBox();
            this.VisitVisitortextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BookVisitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartDateCalendar
            // 
            this.StartDateCalendar.Location = new System.Drawing.Point(274, 34);
            this.StartDateCalendar.MaxSelectionCount = 1;
            this.StartDateCalendar.Name = "StartDateCalendar";
            this.StartDateCalendar.TabIndex = 0;
            this.StartDateCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.StartDateCalendar_DateChanged);
            // 
            // EndDateCalendar
            // 
            this.EndDateCalendar.Location = new System.Drawing.Point(544, 34);
            this.EndDateCalendar.MaxSelectionCount = 1;
            this.EndDateCalendar.Name = "EndDateCalendar";
            this.EndDateCalendar.TabIndex = 1;
            // 
            // VisitInmateTextbox
            // 
            this.VisitInmateTextbox.Location = new System.Drawing.Point(77, 50);
            this.VisitInmateTextbox.Name = "VisitInmateTextbox";
            this.VisitInmateTextbox.Size = new System.Drawing.Size(100, 20);
            this.VisitInmateTextbox.TabIndex = 2;
            // 
            // VisitVisitortextBox
            // 
            this.VisitVisitortextBox.Location = new System.Drawing.Point(77, 127);
            this.VisitVisitortextBox.Name = "VisitVisitortextBox";
            this.VisitVisitortextBox.Size = new System.Drawing.Size(100, 20);
            this.VisitVisitortextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inmate ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Visitor ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "End Date";
            // 
            // BookVisitButton
            // 
            this.BookVisitButton.AllowDrop = true;
            this.BookVisitButton.Location = new System.Drawing.Point(625, 221);
            this.BookVisitButton.Name = "BookVisitButton";
            this.BookVisitButton.Size = new System.Drawing.Size(75, 23);
            this.BookVisitButton.TabIndex = 8;
            this.BookVisitButton.Text = "Book Visit";
            this.BookVisitButton.UseVisualStyleBackColor = true;
            this.BookVisitButton.Click += new System.EventHandler(this.BookVisitButton_Click);
            // 
            // VisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BookVisitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VisitVisitortextBox);
            this.Controls.Add(this.VisitInmateTextbox);
            this.Controls.Add(this.EndDateCalendar);
            this.Controls.Add(this.StartDateCalendar);
            this.Name = "VisitForm";
            this.Text = "Managing Visits Form";
            this.Load += new System.EventHandler(this.VisitForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar StartDateCalendar;
        private System.Windows.Forms.MonthCalendar EndDateCalendar;
        private System.Windows.Forms.TextBox VisitInmateTextbox;
        private System.Windows.Forms.TextBox VisitVisitortextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BookVisitButton;
    }
}