namespace PrisonDBApp
{
    partial class CheckPersonStatusForm
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
            this.CheckFnameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckLnameTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckMinitTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckConvictionButton = new System.Windows.Forms.Button();
            this.CheckNatIDtextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckFnameTextbox
            // 
            this.CheckFnameTextbox.Location = new System.Drawing.Point(73, 77);
            this.CheckFnameTextbox.Name = "CheckFnameTextbox";
            this.CheckFnameTextbox.Size = new System.Drawing.Size(100, 20);
            this.CheckFnameTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 229);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // CheckLnameTextbox
            // 
            this.CheckLnameTextbox.Location = new System.Drawing.Point(528, 77);
            this.CheckLnameTextbox.Name = "CheckLnameTextbox";
            this.CheckLnameTextbox.Size = new System.Drawing.Size(100, 20);
            this.CheckLnameTextbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Middle Initial";
            // 
            // CheckMinitTextbox
            // 
            this.CheckMinitTextbox.Location = new System.Drawing.Point(306, 77);
            this.CheckMinitTextbox.Name = "CheckMinitTextbox";
            this.CheckMinitTextbox.Size = new System.Drawing.Size(100, 20);
            this.CheckMinitTextbox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Check if a person has been incarcerated before using their full name";
            // 
            // CheckConvictionButton
            // 
            this.CheckConvictionButton.Location = new System.Drawing.Point(598, 149);
            this.CheckConvictionButton.Name = "CheckConvictionButton";
            this.CheckConvictionButton.Size = new System.Drawing.Size(125, 40);
            this.CheckConvictionButton.TabIndex = 8;
            this.CheckConvictionButton.Text = "Check Status";
            this.CheckConvictionButton.UseVisualStyleBackColor = true;
            this.CheckConvictionButton.Click += new System.EventHandler(this.CheckConvictionButton_Click);
            // 
            // CheckNatIDtextbox
            // 
            this.CheckNatIDtextbox.Location = new System.Drawing.Point(73, 149);
            this.CheckNatIDtextbox.Name = "CheckNatIDtextbox";
            this.CheckNatIDtextbox.Size = new System.Drawing.Size(100, 20);
            this.CheckNatIDtextbox.TabIndex = 9;
            this.CheckNatIDtextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNatIDtextbox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "NationalID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Or, run a more thorough check using NationalID";
            // 
            // CheckPersonStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CheckNatIDtextbox);
            this.Controls.Add(this.CheckConvictionButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CheckMinitTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckLnameTextbox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckFnameTextbox);
            this.Name = "CheckPersonStatusForm";
            this.Text = "CheckPersonStatusForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CheckFnameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CheckLnameTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CheckMinitTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CheckConvictionButton;
        private System.Windows.Forms.TextBox CheckNatIDtextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}