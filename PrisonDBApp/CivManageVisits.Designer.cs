﻿namespace PrisonDBApp
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
            this.VisitVisitortextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BookVisitButton = new System.Windows.Forms.Button();
            this.InmateNameComboBox = new System.Windows.Forms.ComboBox();
            this.UpdateVisitButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VisitVisitortextBox
            // 
            this.VisitVisitortextBox.Location = new System.Drawing.Point(89, 127);
            this.VisitVisitortextBox.Name = "VisitVisitortextBox";
            this.VisitVisitortextBox.Size = new System.Drawing.Size(100, 20);
            this.VisitVisitortextBox.TabIndex = 3;
            this.VisitVisitortextBox.TextChanged += new System.EventHandler(this.VisitVisitortextBox_TextChanged);
            this.VisitVisitortextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VisitVisitortextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inmate Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Visitor ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "End Date";
            // 
            // BookVisitButton
            // 
            this.BookVisitButton.AllowDrop = true;
            this.BookVisitButton.Location = new System.Drawing.Point(45, 209);
            this.BookVisitButton.Name = "BookVisitButton";
            this.BookVisitButton.Size = new System.Drawing.Size(75, 23);
            this.BookVisitButton.TabIndex = 8;
            this.BookVisitButton.Text = "Book Visit";
            this.BookVisitButton.UseVisualStyleBackColor = true;
            this.BookVisitButton.Click += new System.EventHandler(this.BookVisitButton_Click);
            // 
            // InmateNameComboBox
            // 
            this.InmateNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.InmateNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.InmateNameComboBox.FormattingEnabled = true;
            this.InmateNameComboBox.Location = new System.Drawing.Point(89, 53);
            this.InmateNameComboBox.Name = "InmateNameComboBox";
            this.InmateNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.InmateNameComboBox.TabIndex = 9;
            this.InmateNameComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // UpdateVisitButton
            // 
            this.UpdateVisitButton.Location = new System.Drawing.Point(45, 295);
            this.UpdateVisitButton.Name = "UpdateVisitButton";
            this.UpdateVisitButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateVisitButton.TabIndex = 10;
            this.UpdateVisitButton.Text = "Update Visit";
            this.UpdateVisitButton.UseVisualStyleBackColor = true;
            this.UpdateVisitButton.Click += new System.EventHandler(this.UpdateVisitButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Click here to book a visit for the first time!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(307, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Reselect date and click here if you wish to change a visit\'s date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cancel Visit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(279, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Enter the visit\'s data and click here if you wish to cancel it";
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(500, 46);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(200, 20);
            this.EndDatePicker.TabIndex = 23;
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Location = new System.Drawing.Point(243, 46);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(200, 20);
            this.StartDatePicker.TabIndex = 24;
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.DateTimePicker2_ValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(700, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UpdateVisitButton);
            this.Controls.Add(this.InmateNameComboBox);
            this.Controls.Add(this.BookVisitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VisitVisitortextBox);
            this.Name = "VisitForm";
            this.Text = "Managing Visits Form";
            this.Load += new System.EventHandler(this.VisitForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox VisitVisitortextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BookVisitButton;
        private System.Windows.Forms.ComboBox InmateNameComboBox;
        private System.Windows.Forms.Button UpdateVisitButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.Button button2;
    }
}