namespace PrisonDBApp
{
    partial class GuardRelation
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
            this.InmateIDRelationTextbox = new System.Windows.Forms.TextBox();
            this.VisitorIDRelationInbox = new System.Windows.Forms.TextBox();
            this.RelationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddRelationButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InmateIDRelationTextbox
            // 
            this.InmateIDRelationTextbox.Location = new System.Drawing.Point(93, 59);
            this.InmateIDRelationTextbox.Name = "InmateIDRelationTextbox";
            this.InmateIDRelationTextbox.Size = new System.Drawing.Size(100, 20);
            this.InmateIDRelationTextbox.TabIndex = 0;
            this.InmateIDRelationTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // VisitorIDRelationInbox
            // 
            this.VisitorIDRelationInbox.Location = new System.Drawing.Point(93, 130);
            this.VisitorIDRelationInbox.Name = "VisitorIDRelationInbox";
            this.VisitorIDRelationInbox.Size = new System.Drawing.Size(100, 20);
            this.VisitorIDRelationInbox.TabIndex = 1;
            this.VisitorIDRelationInbox.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            this.VisitorIDRelationInbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_KeyPress);
            // 
            // RelationTextBox
            // 
            this.RelationTextBox.Location = new System.Drawing.Point(93, 210);
            this.RelationTextBox.Name = "RelationTextBox";
            this.RelationTextBox.Size = new System.Drawing.Size(100, 20);
            this.RelationTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "InmateID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "VisitorID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Relation";
            // 
            // AddRelationButton
            // 
            this.AddRelationButton.Location = new System.Drawing.Point(93, 288);
            this.AddRelationButton.Name = "AddRelationButton";
            this.AddRelationButton.Size = new System.Drawing.Size(89, 34);
            this.AddRelationButton.TabIndex = 6;
            this.AddRelationButton.Text = "Add Relation";
            this.AddRelationButton.UseVisualStyleBackColor = true;
            this.AddRelationButton.Click += new System.EventHandler(this.AddRelationButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(11, 329);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 21);
            this.button4.TabIndex = 7;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // GuardRelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 361);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.AddRelationButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RelationTextBox);
            this.Controls.Add(this.VisitorIDRelationInbox);
            this.Controls.Add(this.InmateIDRelationTextbox);
            this.Name = "GuardRelation";
            this.Text = "GuardianRelation";
            this.Load += new System.EventHandler(this.GuardRelation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InmateIDRelationTextbox;
        private System.Windows.Forms.TextBox VisitorIDRelationInbox;
        private System.Windows.Forms.TextBox RelationTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddRelationButton;
        private System.Windows.Forms.Button button4;
    }
}