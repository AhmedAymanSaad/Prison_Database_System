namespace PrisonDBApp
{
    partial class Guard_Warden_Cell_Info
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CellRepairs_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Back_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FacilityRepairs_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MinimumExpense_TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(411, 165);
            this.dataGridView1.TabIndex = 0;
            // 
            // CellRepairs_Button
            // 
            this.CellRepairs_Button.Location = new System.Drawing.Point(303, 15);
            this.CellRepairs_Button.Name = "CellRepairs_Button";
            this.CellRepairs_Button.Size = new System.Drawing.Size(123, 30);
            this.CellRepairs_Button.TabIndex = 1;
            this.CellRepairs_Button.Text = "Excute";
            this.CellRepairs_Button.UseVisualStyleBackColor = true;
            this.CellRepairs_Button.Click += new System.EventHandler(this.CellRepairs_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Press to get the cells that need repairs";
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(12, 337);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(95, 29);
            this.Back_Button.TabIndex = 3;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Press to get the Facilities that need repairs";
            // 
            // FacilityRepairs_Button
            // 
            this.FacilityRepairs_Button.Location = new System.Drawing.Point(296, 76);
            this.FacilityRepairs_Button.Name = "FacilityRepairs_Button";
            this.FacilityRepairs_Button.Size = new System.Drawing.Size(123, 30);
            this.FacilityRepairs_Button.TabIndex = 5;
            this.FacilityRepairs_Button.Text = "Excute";
            this.FacilityRepairs_Button.UseVisualStyleBackColor = true;
            this.FacilityRepairs_Button.Click += new System.EventHandler(this.FacilityRepairs_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Or enter a minimum facility repair expense";
            // 
            // MinimumExpense_TextBox
            // 
            this.MinimumExpense_TextBox.Location = new System.Drawing.Point(291, 112);
            this.MinimumExpense_TextBox.Name = "MinimumExpense_TextBox";
            this.MinimumExpense_TextBox.Size = new System.Drawing.Size(90, 22);
            this.MinimumExpense_TextBox.TabIndex = 7;
            this.MinimumExpense_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinimumExpense_TextBox_KeyPress);
            // 
            // Guard_Warden_Cell_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 378);
            this.Controls.Add(this.MinimumExpense_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FacilityRepairs_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CellRepairs_Button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Guard_Warden_Cell_Info";
            this.Text = "Guard_Warden_Cell_Info";
            this.Load += new System.EventHandler(this.Guard_Warden_Cell_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CellRepairs_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FacilityRepairs_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MinimumExpense_TextBox;
    }
}