using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonDBApp
{
    public partial class CivCheckSentence : Form
    {
        Controller controllerObj;
        int Username;
        Form MyParent;
        public CivCheckSentence(Form P)
        {
            InitializeComponent();
            SentenceMiniTextBox.MaxLength = 1;
            MyParent = P;
            MyParent.Hide();
        }

        private void SentCheckButton_Click(object sender, EventArgs e)
        {
            DataTable dt;
            if ((SentenceMiniTextBox.Text == "" || SentFnameTextbox.Text == "" || SentenceLnameTextbox.Text == "") && (SentNatIDTextbox.Text == ""))
            {
                MessageBox.Show("Please enter either the full name or the nationalID of the convict");
            }
            if (SentNatIDTextbox.Text == "")
            {
                dt = controllerObj.CheckSentenceName(SentFnameTextbox.Text, SentenceMiniTextBox.Text, SentFnameTextbox.Text);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else
            {
                dt = controllerObj.CheckSetnenceID(Int32.Parse(SentNatIDTextbox.Text));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }

        private void SentenceMiniTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
