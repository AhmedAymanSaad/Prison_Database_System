namespace PrisonDBApp
{
    partial class Prison_Warden_Visitation
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
            this.IDs_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VisitsScheduled_comboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CancelVisit_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Back_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // IDs_comboBox
            // 
            this.IDs_comboBox.FormattingEnabled = true;
            this.IDs_comboBox.Location = new System.Drawing.Point(219, 46);
            this.IDs_comboBox.Name = "IDs_comboBox";
            this.IDs_comboBox.Size = new System.Drawing.Size(96, 24);
            this.IDs_comboBox.TabIndex = 0;
            this.IDs_comboBox.SelectedIndexChanged += new System.EventHandler(this.IDs_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inmate ID";
            // 
            // VisitsScheduled_comboBox
            // 
            this.VisitsScheduled_comboBox.FormattingEnabled = true;
            this.VisitsScheduled_comboBox.Location = new System.Drawing.Point(219, 87);
            this.VisitsScheduled_comboBox.Name = "VisitsScheduled_comboBox";
            this.VisitsScheduled_comboBox.Size = new System.Drawing.Size(96, 24);
            this.VisitsScheduled_comboBox.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(467, 159);
            this.dataGridView1.TabIndex = 3;
            // 
            // CancelVisit_button
            // 
            this.CancelVisit_button.Location = new System.Drawing.Point(177, 166);
            this.CancelVisit_button.Name = "CancelVisit_button";
            this.CancelVisit_button.Size = new System.Drawing.Size(138, 29);
            this.CancelVisit_button.TabIndex = 4;
            this.CancelVisit_button.Text = "Cancel Visit";
            this.CancelVisit_button.UseVisualStyleBackColor = true;
            this.CancelVisit_button.Click += new System.EventHandler(this.CancelVisit_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Scheduled Visit number";
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(12, 409);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(113, 29);
            this.Back_button.TabIndex = 6;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "(Ordered by their sequence in the grid)";
            // 
            // Prison_Warden_Visitation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelVisit_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.VisitsScheduled_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDs_comboBox);
            this.Name = "Prison_Warden_Visitation";
            this.Text = "Prison_Warden_Visitation";
            this.Load += new System.EventHandler(this.Prison_Warden_Visitation_Load);
            this.TextChanged += new System.EventHandler(this.Prison_Warden_Visitation_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox IDs_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox VisitsScheduled_comboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CancelVisit_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Label label3;
    }
}