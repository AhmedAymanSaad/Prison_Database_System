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
    public partial class Prison_Warden_Inmates : Form
    {
        Form MyParent;
        Controller controllerObj;
        public Prison_Warden_Inmates(Form P)
        {
            InitializeComponent();
            controllerObj = new Controller();
            MyParent = P;
            MyParent.Hide();

            int IDdefault = controllerObj.SelectTheLastIDAndAddingOne(); // making the default max/last id + 1 
            ID_textBox.Text = IDdefault.ToString();

            label8.Hide();                     // hides the required labels at the beginning
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            label13.Hide();

            MiddleName_textBox.MaxLength = 50;        // makes 1 the maximum size of the middle name 
            FirstName_textBox.MaxLength = 50;        // makes 50 the maximum size of the middle name
            LastName_textBox.MaxLength = 50;
            Charge_textBox.MaxLength = 50;

            DataTable dt = controllerObj.SelectCellNumbersHavingLessThanThreeInmates();
            CellNumber_comboBox.DataSource = dt;
            CellNumber_comboBox.DisplayMember = "CellNumber";

        }

        private void Prison_Warden_Inmates_Load(object sender, EventArgs e)
        {

        }


        private void ViewAllInmates_Button_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllInmates();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void Sentence_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void ID_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Admit_Button_Click(object sender, EventArgs e)
        {
            if (FirstName_textBox.Text == "")
            {
                label8.Visible = true;
                return;
            }
            else if (MiddleName_textBox.Text == "")
            {
                label9.Visible = true;
                return;
            }
            else if (LastName_textBox.Text == "")
            {
                label10.Visible = true;
                return;
            }
            else if (Charge_textBox.Text == "")
            {
                label11.Visible = true;
                return;
            }
            else if (Sentence_textBox.Text == "")
            {
                label12.Visible = true;
                return;
            }
            else if (ID_textBox.Text == "")
            {
                label13.Visible = true;
                return;
            }
            string theDate = dateTimePicker1.Value.ToString("yyyy/MM/dd");

            int Admitting = controllerObj.AdmitAnInmate(Int32.Parse(ID_textBox.Text), FirstName_textBox.Text
                , MiddleName_textBox.Text, LastName_textBox.Text, Charge_textBox.Text, Decimal.Parse(Sentence_textBox.Text),
                Convert.ToDateTime(theDate), Int32.Parse(CellNumber_comboBox.Text));

            if (Admitting == 0)
            {
                MessageBox.Show("The Admission of a new inmate failed");
            }
            else if (Admitting == 1)
            {
                label8.Hide();
                label9.Hide();
                label10.Hide();
                label11.Hide();
                label12.Hide();
                label13.Hide();

                int IDdefault = controllerObj.SelectTheLastIDAndAddingOne(); // making the default max/last id + 1 
                ID_textBox.Text = IDdefault.ToString();

                DataTable dt = controllerObj.SelectCellNumbersHavingLessThanThreeInmates();
                CellNumber_comboBox.DataSource = dt;
                CellNumber_comboBox.DisplayMember = "CellNumber";


                FirstName_textBox.Text ="";
                MiddleName_textBox.Text = "";
                LastName_textBox.Text = "";
                Charge_textBox.Text = "";
                Sentence_textBox.Text = "";



                MessageBox.Show(FirstName_textBox.Text + " is Admitted successfully!");
            }



        }
    }
}
