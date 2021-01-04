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
    public partial class Prison_Warden___Hiring_And_Firing_Guards : Form
    {
        Controller controllerObj;
        Form MyParent;
        public Prison_Warden___Hiring_And_Firing_Guards(Form P)
        {
            InitializeComponent();
            MyParent = P;
            MyParent.Hide();

            IDCheck_Label.Hide();                     // hides the required labels at the beginning
            LastnameCheck_Label.Hide();
            FirstnameCheck_Label.Hide();
            MiddlenameCheck_Label.Hide();

            MiddleName_TextBox.MaxLength = 1;        // makes 1 the maximum size of the middle name 
            FirstName_TextBox.MaxLength = 50;        // makes 50 the maximum size of the middle name
            LastName_TextBox.MaxLength = 50;

            controllerObj = new Controller();                     // adding the sectors ID to a combobox
            DataTable dt = controllerObj.SelectAllSectors();
            Sector_ComboBox.DataSource = dt;
            Sector_ComboBox.DisplayMember = "SectorID";

            DataTable dt1 = controllerObj.SelectAllSupercisors();      // adding the supervisors ID to a combobox
            SupervisorID_ComboBox.DataSource = dt1;
            SupervisorID_ComboBox.DisplayMember = "Supervisor_ID";

            DataTable dt2 = controllerObj.SelectGuardTypes();          // adding the GuardTypes to a combobox
            Type_ComboBox.DataSource = dt2;
            Type_ComboBox.DisplayMember = "Type";

            DataTable dt3 = controllerObj.SelectAllGuardIDs();          // adding the GuardTypes to a combobox
            IDs_ComboBox.DataSource = dt3;
            IDs_ComboBox.DisplayMember = "ID";

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Prison_Warden___Hiring_And_Firing_Guards_Load(object sender, EventArgs e)
        {

        }

        //----------------------------------Hiring A Gurad---------------------------------------------
        private void Hire_Button_Click(object sender, EventArgs e)
        {
            if (GuardID_TextBox.Text == "")
            {
                IDCheck_Label.Visible=true;
                return;
            }
            else if (FirstName_TextBox.Text=="")
            {
                FirstnameCheck_Label.Visible = true;
                return;
            }
            else if (MiddleName_TextBox.Text == "")
            {
                MiddlenameCheck_Label.Visible = true;
                return;
            }
            else if (LastName_TextBox.Text == "")
            {
                LastnameCheck_Label.Visible = true;
                return;
            }

            int Hiring;
            if (SupervisorID_ComboBox.Text == "")
            {
                Hiring = controllerObj.HireAHeadGuard(Int32.Parse(GuardID_TextBox.Text), FirstName_TextBox.Text
                    , Char.Parse(MiddleName_TextBox.Text), LastName_TextBox.Text, Type_ComboBox.Text,
                    Int32.Parse(Sector_ComboBox.Text));
            }
            else
            {
                Hiring = controllerObj.HireAGuard(Int32.Parse(GuardID_TextBox.Text), FirstName_TextBox.Text
                , Char.Parse(MiddleName_TextBox.Text), LastName_TextBox.Text, Type_ComboBox.Text,
                Int32.Parse(SupervisorID_ComboBox.Text), Int32.Parse(Sector_ComboBox.Text));
            }
            if (Hiring == 0)
            {
                MessageBox.Show("The insertion of a new Guard failed");
            }
            else if (Hiring == 1)
            {
                MessageBox.Show( FirstName_TextBox.Text + " is Hired successfully!");

                IDCheck_Label.Hide();                    
                LastnameCheck_Label.Hide();
                FirstnameCheck_Label.Hide();
                MiddlenameCheck_Label.Hide();

            }
        }


        //-------------------------------------------------------------------------------------------------------------------
        private void GuardID_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewGuards_Button_Click(object sender, EventArgs e)
        {

            DataTable dt = controllerObj.SelectAllGuards();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void FireGuard_Button_Click(object sender, EventArgs e)
        {
            int firing = controllerObj.FireAGuard(Int32.Parse(IDs_ComboBox.Text));
            if (firing == 1)
            {
                MessageBox.Show("Guard with ID number " +IDs_ComboBox.Text + " is fired");
            }
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            MyParent.Visible = true;
            this.Hide();
        }
    }
}
