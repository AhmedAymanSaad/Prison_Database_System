namespace PrisonDBApp
{
    partial class CivCheckSentence
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
            this.components = new System.ComponentModel.Container();
            this.SentFnameTextbox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SentenceMiniTextBox = new System.Windows.Forms.TextBox();
            this.SentenceLnameTextbox = new System.Windows.Forms.TextBox();
            this.SentNatIDTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NationalID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SentCheckButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SentFnameTextbox
            // 
            this.SentFnameTextbox.Location = new System.Drawing.Point(90, 80);
            this.SentFnameTextbox.Name = "SentFnameTextbox";
            this.SentFnameTextbox.Size = new System.Drawing.Size(100, 20);
            this.SentFnameTextbox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SentenceMiniTextBox
            // 
            this.SentenceMiniTextBox.Location = new System.Drawing.Point(279, 80);
            this.SentenceMiniTextBox.Name = "SentenceMiniTextBox";
            this.SentenceMiniTextBox.Size = new System.Drawing.Size(100, 20);
            this.SentenceMiniTextBox.TabIndex = 2;
            this.SentenceMiniTextBox.TextChanged += new System.EventHandler(this.SentenceMiniTextBox_TextChanged);
            // 
            // SentenceLnameTextbox
            // 
            this.SentenceLnameTextbox.Location = new System.Drawing.Point(461, 79);
            this.SentenceLnameTextbox.Name = "SentenceLnameTextbox";
            this.SentenceLnameTextbox.Size = new System.Drawing.Size(100, 20);
            this.SentenceLnameTextbox.TabIndex = 3;
            // 
            // SentNatIDTextbox
            // 
            this.SentNatIDTextbox.Location = new System.Drawing.Point(90, 166);
            this.SentNatIDTextbox.Name = "SentNatIDTextbox";
            this.SentNatIDTextbox.Size = new System.Drawing.Size(100, 20);
            this.SentNatIDTextbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Check using a person\'s full name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Run a more thorough check through their ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = " middle initial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Last Name";
            // 
            // NationalID
            // 
            this.NationalID.AutoSize = true;
            this.NationalID.Location = new System.Drawing.Point(12, 169);
            this.NationalID.Name = "NationalID";
            this.NationalID.Size = new System.Drawing.Size(57, 13);
            this.NationalID.TabIndex = 10;
            this.NationalID.Text = "NationalID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(209, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 152);
            this.dataGridView1.TabIndex = 11;
            // 
            // SentCheckButton
            // 
            this.SentCheckButton.Location = new System.Drawing.Point(486, 131);
            this.SentCheckButton.Name = "SentCheckButton";
            this.SentCheckButton.Size = new System.Drawing.Size(75, 23);
            this.SentCheckButton.TabIndex = 12;
            this.SentCheckButton.Text = "Check";
            this.SentCheckButton.UseVisualStyleBackColor = true;
            this.SentCheckButton.Click += new System.EventHandler(this.SentCheckButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CivCheckSentence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 386);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SentCheckButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NationalID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SentNatIDTextbox);
            this.Controls.Add(this.SentenceLnameTextbox);
            this.Controls.Add(this.SentenceMiniTextBox);
            this.Controls.Add(this.SentFnameTextbox);
            this.Name = "CivCheckSentence";
            this.Text = "CivCheckSentence";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SentFnameTextbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox SentenceMiniTextBox;
        private System.Windows.Forms.TextBox SentenceLnameTextbox;
        private System.Windows.Forms.TextBox SentNatIDTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NationalID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SentCheckButton;
        private System.Windows.Forms.Button button1;
    }
}