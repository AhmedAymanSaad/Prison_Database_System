﻿namespace PrisonDBApp
{
    partial class Prison_Warden___Hiring_And_Firing_Guards
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GuardID_TextBox = new System.Windows.Forms.TextBox();
            this.FirstName_TextBox = new System.Windows.Forms.TextBox();
            this.MiddleName_TextBox = new System.Windows.Forms.TextBox();
            this.LastName_TextBox = new System.Windows.Forms.TextBox();
            this.Type_ComboBox = new System.Windows.Forms.ComboBox();
            this.SupervisorID_ComboBox = new System.Windows.Forms.ComboBox();
            this.Sector_ComboBox = new System.Windows.Forms.ComboBox();
            this.Hire_Button = new System.Windows.Forms.Button();
            this.IDCheck_Label = new System.Windows.Forms.Label();
            this.FirstnameCheck_Label = new System.Windows.Forms.Label();
            this.MiddlenameCheck_Label = new System.Windows.Forms.Label();
            this.LastnameCheck_Label = new System.Windows.Forms.Label();
            this.ViewGuards_Button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FireGuard_Button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.IDs_ComboBox = new System.Windows.Forms.ComboBox();
            this.Back_Button = new System.Windows.Forms.Button();
            this.NewType_comboBox = new System.Windows.Forms.ComboBox();
            this.NewSupervisor_comboBox = new System.Windows.Forms.ComboBox();
            this.NewSector_comboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Update_button = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Guard\'s ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Middle name Initial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Supervisor ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Assigned Sector";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "First name";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // GuardID_TextBox
            // 
            this.GuardID_TextBox.Location = new System.Drawing.Point(164, 30);
            this.GuardID_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GuardID_TextBox.Name = "GuardID_TextBox";
            this.GuardID_TextBox.Size = new System.Drawing.Size(123, 22);
            this.GuardID_TextBox.TabIndex = 8;
            this.GuardID_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GuardID_TextBox_KeyPress);
            // 
            // FirstName_TextBox
            // 
            this.FirstName_TextBox.Location = new System.Drawing.Point(164, 100);
            this.FirstName_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirstName_TextBox.Name = "FirstName_TextBox";
            this.FirstName_TextBox.Size = new System.Drawing.Size(123, 22);
            this.FirstName_TextBox.TabIndex = 9;
            this.FirstName_TextBox.TextChanged += new System.EventHandler(this.FirstName_TextBox_TextChanged);
            // 
            // MiddleName_TextBox
            // 
            this.MiddleName_TextBox.Location = new System.Drawing.Point(164, 128);
            this.MiddleName_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MiddleName_TextBox.Name = "MiddleName_TextBox";
            this.MiddleName_TextBox.Size = new System.Drawing.Size(123, 22);
            this.MiddleName_TextBox.TabIndex = 10;
            this.MiddleName_TextBox.TextChanged += new System.EventHandler(this.MiddleName_TextBox_TextChanged);
            // 
            // LastName_TextBox
            // 
            this.LastName_TextBox.Location = new System.Drawing.Point(164, 158);
            this.LastName_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastName_TextBox.Name = "LastName_TextBox";
            this.LastName_TextBox.Size = new System.Drawing.Size(123, 22);
            this.LastName_TextBox.TabIndex = 11;
            this.LastName_TextBox.TextChanged += new System.EventHandler(this.LastName_TextBox_TextChanged);
            // 
            // Type_ComboBox
            // 
            this.Type_ComboBox.FormattingEnabled = true;
            this.Type_ComboBox.Location = new System.Drawing.Point(164, 223);
            this.Type_ComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Type_ComboBox.Name = "Type_ComboBox";
            this.Type_ComboBox.Size = new System.Drawing.Size(120, 24);
            this.Type_ComboBox.TabIndex = 13;
            // 
            // SupervisorID_ComboBox
            // 
            this.SupervisorID_ComboBox.FormattingEnabled = true;
            this.SupervisorID_ComboBox.Location = new System.Drawing.Point(164, 274);
            this.SupervisorID_ComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SupervisorID_ComboBox.Name = "SupervisorID_ComboBox";
            this.SupervisorID_ComboBox.Size = new System.Drawing.Size(120, 24);
            this.SupervisorID_ComboBox.TabIndex = 14;
            // 
            // Sector_ComboBox
            // 
            this.Sector_ComboBox.FormattingEnabled = true;
            this.Sector_ComboBox.Location = new System.Drawing.Point(164, 330);
            this.Sector_ComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sector_ComboBox.Name = "Sector_ComboBox";
            this.Sector_ComboBox.Size = new System.Drawing.Size(120, 24);
            this.Sector_ComboBox.TabIndex = 15;
            // 
            // Hire_Button
            // 
            this.Hire_Button.Location = new System.Drawing.Point(197, 370);
            this.Hire_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Hire_Button.Name = "Hire_Button";
            this.Hire_Button.Size = new System.Drawing.Size(136, 33);
            this.Hire_Button.TabIndex = 16;
            this.Hire_Button.Text = "Hire";
            this.Hire_Button.UseVisualStyleBackColor = true;
            this.Hire_Button.Click += new System.EventHandler(this.Hire_Button_Click);
            // 
            // IDCheck_Label
            // 
            this.IDCheck_Label.AutoSize = true;
            this.IDCheck_Label.ForeColor = System.Drawing.Color.Red;
            this.IDCheck_Label.Location = new System.Drawing.Point(293, 33);
            this.IDCheck_Label.Name = "IDCheck_Label";
            this.IDCheck_Label.Size = new System.Drawing.Size(71, 17);
            this.IDCheck_Label.TabIndex = 17;
            this.IDCheck_Label.Text = "Required*";
            // 
            // FirstnameCheck_Label
            // 
            this.FirstnameCheck_Label.AutoSize = true;
            this.FirstnameCheck_Label.ForeColor = System.Drawing.Color.Red;
            this.FirstnameCheck_Label.Location = new System.Drawing.Point(293, 105);
            this.FirstnameCheck_Label.Name = "FirstnameCheck_Label";
            this.FirstnameCheck_Label.Size = new System.Drawing.Size(71, 17);
            this.FirstnameCheck_Label.TabIndex = 18;
            this.FirstnameCheck_Label.Text = "Required*";
            // 
            // MiddlenameCheck_Label
            // 
            this.MiddlenameCheck_Label.AutoSize = true;
            this.MiddlenameCheck_Label.ForeColor = System.Drawing.Color.Red;
            this.MiddlenameCheck_Label.Location = new System.Drawing.Point(293, 133);
            this.MiddlenameCheck_Label.Name = "MiddlenameCheck_Label";
            this.MiddlenameCheck_Label.Size = new System.Drawing.Size(71, 17);
            this.MiddlenameCheck_Label.TabIndex = 19;
            this.MiddlenameCheck_Label.Text = "Required*";
            // 
            // LastnameCheck_Label
            // 
            this.LastnameCheck_Label.AutoSize = true;
            this.LastnameCheck_Label.ForeColor = System.Drawing.Color.Red;
            this.LastnameCheck_Label.Location = new System.Drawing.Point(293, 161);
            this.LastnameCheck_Label.Name = "LastnameCheck_Label";
            this.LastnameCheck_Label.Size = new System.Drawing.Size(71, 17);
            this.LastnameCheck_Label.TabIndex = 20;
            this.LastnameCheck_Label.Text = "Required*";
            // 
            // ViewGuards_Button
            // 
            this.ViewGuards_Button.Location = new System.Drawing.Point(561, 402);
            this.ViewGuards_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewGuards_Button.Name = "ViewGuards_Button";
            this.ViewGuards_Button.Size = new System.Drawing.Size(153, 25);
            this.ViewGuards_Button.TabIndex = 21;
            this.ViewGuards_Button.Text = "View All Guards";
            this.ViewGuards_Button.UseVisualStyleBackColor = true;
            this.ViewGuards_Button.Click += new System.EventHandler(this.ViewGuards_Button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(384, 238);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(404, 148);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FireGuard_Button
            // 
            this.FireGuard_Button.Location = new System.Drawing.Point(648, 194);
            this.FireGuard_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FireGuard_Button.Name = "FireGuard_Button";
            this.FireGuard_Button.Size = new System.Drawing.Size(140, 28);
            this.FireGuard_Button.TabIndex = 23;
            this.FireGuard_Button.Text = "Fire";
            this.FireGuard_Button.UseVisualStyleBackColor = true;
            this.FireGuard_Button.Click += new System.EventHandler(this.FireGuard_Button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(299, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Select the ID of the guard to be Fired/Updated";
            // 
            // IDs_ComboBox
            // 
            this.IDs_ComboBox.FormattingEnabled = true;
            this.IDs_ComboBox.Location = new System.Drawing.Point(713, 12);
            this.IDs_ComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDs_ComboBox.Name = "IDs_ComboBox";
            this.IDs_ComboBox.Size = new System.Drawing.Size(75, 24);
            this.IDs_ComboBox.TabIndex = 25;
            this.IDs_ComboBox.SelectedIndexChanged += new System.EventHandler(this.IDs_ComboBox_SelectedIndexChanged);
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(24, 402);
            this.Back_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(81, 32);
            this.Back_Button.TabIndex = 26;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // NewType_comboBox
            // 
            this.NewType_comboBox.FormattingEnabled = true;
            this.NewType_comboBox.Location = new System.Drawing.Point(648, 69);
            this.NewType_comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewType_comboBox.Name = "NewType_comboBox";
            this.NewType_comboBox.Size = new System.Drawing.Size(108, 24);
            this.NewType_comboBox.TabIndex = 27;
            // 
            // NewSupervisor_comboBox
            // 
            this.NewSupervisor_comboBox.FormattingEnabled = true;
            this.NewSupervisor_comboBox.Location = new System.Drawing.Point(648, 98);
            this.NewSupervisor_comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewSupervisor_comboBox.Name = "NewSupervisor_comboBox";
            this.NewSupervisor_comboBox.Size = new System.Drawing.Size(108, 24);
            this.NewSupervisor_comboBox.TabIndex = 28;
            // 
            // NewSector_comboBox
            // 
            this.NewSector_comboBox.FormattingEnabled = true;
            this.NewSector_comboBox.Location = new System.Drawing.Point(648, 128);
            this.NewSector_comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewSector_comboBox.Name = "NewSector_comboBox";
            this.NewSector_comboBox.Size = new System.Drawing.Size(108, 24);
            this.NewSector_comboBox.TabIndex = 29;
            this.NewSector_comboBox.SelectedIndexChanged += new System.EventHandler(this.NewSector_comboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(487, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "Change guard type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(487, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Assign new supervisor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(487, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Change assigned sector";
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(483, 194);
            this.Update_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(133, 27);
            this.Update_button.TabIndex = 33;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(645, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 17);
            this.label12.TabIndex = 34;
            this.label12.Text = "Only ID required here";
            // 
            // Prison_Warden___Hiring_And_Firing_Guards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NewSector_comboBox);
            this.Controls.Add(this.NewSupervisor_comboBox);
            this.Controls.Add(this.NewType_comboBox);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.IDs_ComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FireGuard_Button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ViewGuards_Button);
            this.Controls.Add(this.LastnameCheck_Label);
            this.Controls.Add(this.MiddlenameCheck_Label);
            this.Controls.Add(this.FirstnameCheck_Label);
            this.Controls.Add(this.IDCheck_Label);
            this.Controls.Add(this.Hire_Button);
            this.Controls.Add(this.Sector_ComboBox);
            this.Controls.Add(this.SupervisorID_ComboBox);
            this.Controls.Add(this.Type_ComboBox);
            this.Controls.Add(this.LastName_TextBox);
            this.Controls.Add(this.MiddleName_TextBox);
            this.Controls.Add(this.FirstName_TextBox);
            this.Controls.Add(this.GuardID_TextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Prison_Warden___Hiring_And_Firing_Guards";
            this.Text = "Prison_Warden___Hiring_And_Firing_Guards";
            this.Load += new System.EventHandler(this.Prison_Warden___Hiring_And_Firing_Guards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox GuardID_TextBox;
        private System.Windows.Forms.TextBox FirstName_TextBox;
        private System.Windows.Forms.TextBox MiddleName_TextBox;
        private System.Windows.Forms.TextBox LastName_TextBox;
        private System.Windows.Forms.ComboBox Type_ComboBox;
        private System.Windows.Forms.ComboBox SupervisorID_ComboBox;
        private System.Windows.Forms.ComboBox Sector_ComboBox;
        private System.Windows.Forms.Button Hire_Button;
        private System.Windows.Forms.Label IDCheck_Label;
        private System.Windows.Forms.Label FirstnameCheck_Label;
        private System.Windows.Forms.Label MiddlenameCheck_Label;
        private System.Windows.Forms.Label LastnameCheck_Label;
        private System.Windows.Forms.Button ViewGuards_Button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button FireGuard_Button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox IDs_ComboBox;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.ComboBox NewType_comboBox;
        private System.Windows.Forms.ComboBox NewSupervisor_comboBox;
        private System.Windows.Forms.ComboBox NewSector_comboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Label label12;
    }
}