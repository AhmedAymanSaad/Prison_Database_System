namespace PrisonDBApp
{
    partial class Prison_Warden_Inmates
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.FirstName_textBox = new System.Windows.Forms.TextBox();
            this.MiddleName_textBox = new System.Windows.Forms.TextBox();
            this.LastName_textBox = new System.Windows.Forms.TextBox();
            this.Charge_textBox = new System.Windows.Forms.TextBox();
            this.Sentence_textBox = new System.Windows.Forms.TextBox();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.CellNumber_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Admit_Button = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ViewAllInmates_Button = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.InmatesID_comboBox = new System.Windows.Forms.ComboBox();
            this.TransferInmateByID_comboBox = new System.Windows.Forms.ComboBox();
            this.ReleaseInmateByID_comboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ReleaseInmate_Button = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.TransferInmate_Button = new System.Windows.Forms.Button();
            this.ProhibationPeriod_TextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.NationalID_TextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.Back_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(224, 29);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // FirstName_textBox
            // 
            this.FirstName_textBox.Location = new System.Drawing.Point(128, 74);
            this.FirstName_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FirstName_textBox.Name = "FirstName_textBox";
            this.FirstName_textBox.Size = new System.Drawing.Size(91, 20);
            this.FirstName_textBox.TabIndex = 1;
            // 
            // MiddleName_textBox
            // 
            this.MiddleName_textBox.Location = new System.Drawing.Point(128, 105);
            this.MiddleName_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MiddleName_textBox.Name = "MiddleName_textBox";
            this.MiddleName_textBox.Size = new System.Drawing.Size(91, 20);
            this.MiddleName_textBox.TabIndex = 2;
            // 
            // LastName_textBox
            // 
            this.LastName_textBox.Location = new System.Drawing.Point(128, 140);
            this.LastName_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LastName_textBox.Name = "LastName_textBox";
            this.LastName_textBox.Size = new System.Drawing.Size(91, 20);
            this.LastName_textBox.TabIndex = 3;
            // 
            // Charge_textBox
            // 
            this.Charge_textBox.Location = new System.Drawing.Point(128, 178);
            this.Charge_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Charge_textBox.Name = "Charge_textBox";
            this.Charge_textBox.Size = new System.Drawing.Size(138, 20);
            this.Charge_textBox.TabIndex = 4;
            // 
            // Sentence_textBox
            // 
            this.Sentence_textBox.Location = new System.Drawing.Point(128, 216);
            this.Sentence_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sentence_textBox.Name = "Sentence_textBox";
            this.Sentence_textBox.Size = new System.Drawing.Size(91, 20);
            this.Sentence_textBox.TabIndex = 5;
            this.Sentence_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sentence_textBox_KeyPress);
            // 
            // ID_textBox
            // 
            this.ID_textBox.Location = new System.Drawing.Point(128, 247);
            this.ID_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(91, 20);
            this.ID_textBox.TabIndex = 6;
            this.ID_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_textBox_KeyPress);
            // 
            // CellNumber_comboBox
            // 
            this.CellNumber_comboBox.FormattingEnabled = true;
            this.CellNumber_comboBox.Location = new System.Drawing.Point(128, 280);
            this.CellNumber_comboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CellNumber_comboBox.Name = "CellNumber_comboBox";
            this.CellNumber_comboBox.Size = new System.Drawing.Size(91, 21);
            this.CellNumber_comboBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Middle Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Charge";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sentence (years)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 285);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "New Cell Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 247);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "New ID";
            // 
            // Admit_Button
            // 
            this.Admit_Button.Location = new System.Drawing.Point(128, 315);
            this.Admit_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Admit_Button.Name = "Admit_Button";
            this.Admit_Button.Size = new System.Drawing.Size(87, 24);
            this.Admit_Button.TabIndex = 15;
            this.Admit_Button.Text = "Admit Inmate";
            this.Admit_Button.UseVisualStyleBackColor = true;
            this.Admit_Button.Click += new System.EventHandler(this.Admit_Button_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(222, 251);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Required*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(222, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Required*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(222, 109);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Required*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(222, 142);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Required*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(269, 180);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Required*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(222, 220);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Required*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(248, 13);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Date of Conviction/Release ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(237, 336);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(416, 130);
            this.dataGridView1.TabIndex = 25;
            // 
            // ViewAllInmates_Button
            // 
            this.ViewAllInmates_Button.Location = new System.Drawing.Point(98, 422);
            this.ViewAllInmates_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ViewAllInmates_Button.Name = "ViewAllInmates_Button";
            this.ViewAllInmates_Button.Size = new System.Drawing.Size(106, 24);
            this.ViewAllInmates_Button.TabIndex = 26;
            this.ViewAllInmates_Button.Text = "View Inmate";
            this.ViewAllInmates_Button.UseVisualStyleBackColor = true;
            this.ViewAllInmates_Button.Click += new System.EventHandler(this.ViewAllInmates_Button_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 401);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Select an Inmate Using his ID";
            // 
            // InmatesID_comboBox
            // 
            this.InmatesID_comboBox.FormattingEnabled = true;
            this.InmatesID_comboBox.Location = new System.Drawing.Point(158, 398);
            this.InmatesID_comboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InmatesID_comboBox.Name = "InmatesID_comboBox";
            this.InmatesID_comboBox.Size = new System.Drawing.Size(62, 21);
            this.InmatesID_comboBox.TabIndex = 30;
            // 
            // TransferInmateByID_comboBox
            // 
            this.TransferInmateByID_comboBox.FormattingEnabled = true;
            this.TransferInmateByID_comboBox.Location = new System.Drawing.Point(526, 251);
            this.TransferInmateByID_comboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TransferInmateByID_comboBox.Name = "TransferInmateByID_comboBox";
            this.TransferInmateByID_comboBox.Size = new System.Drawing.Size(82, 21);
            this.TransferInmateByID_comboBox.TabIndex = 31;
            // 
            // ReleaseInmateByID_comboBox
            // 
            this.ReleaseInmateByID_comboBox.FormattingEnabled = true;
            this.ReleaseInmateByID_comboBox.Location = new System.Drawing.Point(526, 77);
            this.ReleaseInmateByID_comboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReleaseInmateByID_comboBox.Name = "ReleaseInmateByID_comboBox";
            this.ReleaseInmateByID_comboBox.Size = new System.Drawing.Size(82, 21);
            this.ReleaseInmateByID_comboBox.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(377, 80);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "ID of Inmate to be released";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // ReleaseInmate_Button
            // 
            this.ReleaseInmate_Button.Location = new System.Drawing.Point(526, 153);
            this.ReleaseInmate_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReleaseInmate_Button.Name = "ReleaseInmate_Button";
            this.ReleaseInmate_Button.Size = new System.Drawing.Size(94, 25);
            this.ReleaseInmate_Button.TabIndex = 34;
            this.ReleaseInmate_Button.Text = "Release Inmate";
            this.ReleaseInmate_Button.UseVisualStyleBackColor = true;
            this.ReleaseInmate_Button.Click += new System.EventHandler(this.ReleaseInmate_Button_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(373, 257);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(156, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "ID of Inmate to be Transferred";
            // 
            // TransferInmate_Button
            // 
            this.TransferInmate_Button.Location = new System.Drawing.Point(526, 276);
            this.TransferInmate_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TransferInmate_Button.Name = "TransferInmate_Button";
            this.TransferInmate_Button.Size = new System.Drawing.Size(94, 25);
            this.TransferInmate_Button.TabIndex = 36;
            this.TransferInmate_Button.Text = "Transfer Inmate";
            this.TransferInmate_Button.UseVisualStyleBackColor = true;
            this.TransferInmate_Button.Click += new System.EventHandler(this.TransferInmate_Button_Click);
            // 
            // ProhibationPeriod_TextBox
            // 
            this.ProhibationPeriod_TextBox.Location = new System.Drawing.Point(526, 130);
            this.ProhibationPeriod_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProhibationPeriod_TextBox.Name = "ProhibationPeriod_TextBox";
            this.ProhibationPeriod_TextBox.Size = new System.Drawing.Size(82, 20);
            this.ProhibationPeriod_TextBox.TabIndex = 37;
            this.ProhibationPeriod_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProhibationPeriod_TextBox_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(380, 134);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(132, 13);
            this.label18.TabIndex = 38;
            this.label18.Text = "Prohibation Period (years)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(611, 107);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "Required*";
            // 
            // NationalID_TextBox
            // 
            this.NationalID_TextBox.Location = new System.Drawing.Point(526, 105);
            this.NationalID_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NationalID_TextBox.Name = "NationalID_TextBox";
            this.NationalID_TextBox.Size = new System.Drawing.Size(82, 20);
            this.NationalID_TextBox.TabIndex = 40;
            this.NationalID_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NationalID_TextBox_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(456, 109);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 13);
            this.label20.TabIndex = 41;
            this.label20.Text = "NationalID";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(611, 132);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 13);
            this.label21.TabIndex = 42;
            this.label21.Text = "Required*";
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(11, 13);
            this.Back_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(74, 20);
            this.Back_Button.TabIndex = 43;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Prison_Warden_Inmates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 475);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.NationalID_TextBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.ProhibationPeriod_TextBox);
            this.Controls.Add(this.TransferInmate_Button);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.ReleaseInmate_Button);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ReleaseInmateByID_comboBox);
            this.Controls.Add(this.TransferInmateByID_comboBox);
            this.Controls.Add(this.InmatesID_comboBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ViewAllInmates_Button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Admit_Button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CellNumber_comboBox);
            this.Controls.Add(this.ID_textBox);
            this.Controls.Add(this.Sentence_textBox);
            this.Controls.Add(this.Charge_textBox);
            this.Controls.Add(this.LastName_textBox);
            this.Controls.Add(this.MiddleName_textBox);
            this.Controls.Add(this.FirstName_textBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Prison_Warden_Inmates";
            this.Text = "Prison_Warden_Inmates";
            this.Load += new System.EventHandler(this.Prison_Warden_Inmates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox FirstName_textBox;
        private System.Windows.Forms.TextBox MiddleName_textBox;
        private System.Windows.Forms.TextBox LastName_textBox;
        private System.Windows.Forms.TextBox Charge_textBox;
        private System.Windows.Forms.TextBox Sentence_textBox;
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.ComboBox CellNumber_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Admit_Button;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ViewAllInmates_Button;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox InmatesID_comboBox;
        private System.Windows.Forms.ComboBox TransferInmateByID_comboBox;
        private System.Windows.Forms.ComboBox ReleaseInmateByID_comboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button ReleaseInmate_Button;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button TransferInmate_Button;
        private System.Windows.Forms.TextBox ProhibationPeriod_TextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox NationalID_TextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button Back_Button;
    }
}