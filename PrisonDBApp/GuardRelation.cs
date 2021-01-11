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
    public partial class GuardRelation : Form
    {
        Controller controllerObj;
        Form MyParent;
        public GuardRelation(Form P)
        {
            controllerObj = new Controller();
            InitializeComponent();
            MyParent = P;
            P.Hide();
            
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void GuardRelation_Load(object sender, EventArgs e)
        {

        }

        private void AddRelationButton_Click(object sender, EventArgs e)
        {
            int AddRelationStatus;
            if (VisitorIDRelationInbox.Text == "" || InmateIDRelationTextbox.Text == "" || RelationTextBox.Text == "")
            {
                MessageBox.Show("Please fill in all the information");

            }
            else
            {
                AddRelationStatus = controllerObj.InsertRelation(Int32.Parse(InmateIDRelationTextbox.Text), Int32.Parse(InmateIDRelationTextbox.Text),
                    RelationTextBox.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyParent.Visible = true;
            this.Hide();
        }
    }
}
