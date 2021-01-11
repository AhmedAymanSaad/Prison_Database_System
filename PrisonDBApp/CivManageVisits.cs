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
    public partial class VisitForm : Form
    {
        Controller controllerObj;
        Form MyParent;
        int Username;
        public VisitForm(Form P, int UN)
        {
            Username = UN;
            controllerObj = new Controller();
            InitializeComponent();
            MyParent = P;
            MyParent.Hide();
            DataTable dt = controllerObj.GetInmateNames(Username);
            InmateNameComboBox.DataSource = dt;
            InmateNameComboBox.DisplayMember = "Inmate Name";

            StartDatePicker.Format = DateTimePickerFormat.Custom;
            StartDatePicker.CustomFormat = "yyyy/MM/dd hh:mm:ss";

            EndDatePicker.Format = DateTimePickerFormat.Custom;
            EndDatePicker.CustomFormat = "yyyy/MM/dd hh:mm:ss";

        }

        private void VisitForm_Load(object sender, EventArgs e)
        {

        }

       

        private void BookVisitButton_Click(object sender, EventArgs e)
        {
            int BookVisit;
            
           
            
            if (StartDatePicker.Value > EndDatePicker.Value)
            {
                MessageBox.Show("The end date must be greater than the start date");
            }
            else if (VisitVisitortextBox.Text == "" || InmateNameComboBox.Text == "")
            {
                MessageBox.Show("Please enter your nationalID and the visitee's name");
            }
            else
            {
                BookVisit = controllerObj.InsertAVisit(InmateNameComboBox.Text, Int32.Parse(VisitVisitortextBox.Text), StartDatePicker.Value,
                   EndDatePicker.Value);
                if (BookVisit == 0)
                {
                    MessageBox.Show("visit could not be booked, please check data and that a visit is possible");
                }
                else
                {
                    MessageBox.Show("Visit booked!");
                }
            }
                
        }

        

        private void StartDateCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VisitVisitortextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void VisitVisitortextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void UpdateVisitButton_Click(object sender, EventArgs e)
        {
            int UpdateVisit;



            if ((StartDatePicker.Value) > (EndDatePicker.Value))
            {
                MessageBox.Show("The end date must be greater than the start date");
            }
            else if (VisitVisitortextBox.Text == "" || InmateNameComboBox.Text == "")
            {
                MessageBox.Show("Please enter your nationalID and the visitee's name");
            }

            else
            {
                UpdateVisit = controllerObj.UpdateAVisit(InmateNameComboBox.Text, Int32.Parse(VisitVisitortextBox.Text), (StartDatePicker.Value),
                    (EndDatePicker.Value));

                if (UpdateVisit == 0)
                {
                    MessageBox.Show("visit could not be updated, please check data and that a visit exists");
                }
                else
                {
                    MessageBox.Show("Visit Updated!");
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int DeleteVisit;

            if ((StartDatePicker.Value) > (StartDatePicker.Value))
            {
                MessageBox.Show("The end date must be greater than the start date");
            }
            else if (VisitVisitortextBox.Text == "" || InmateNameComboBox.Text == "")
            {
                MessageBox.Show("Please enter your nationalID and the visitee's name");
            }
            else
            {

                DeleteVisit = controllerObj.DeleteAVisit(InmateNameComboBox.Text, Int32.Parse(VisitVisitortextBox.Text), (StartDatePicker.Value),
                    (EndDatePicker.Value));
                if (DeleteVisit == 0)
                {
                    MessageBox.Show("visit could not be deleted, please check data and that it exists");
                }
                else
                {
                    MessageBox.Show("Visit deleted!");
                }
            }
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyParent.Visible = true;
            this.Hide();
        }
    }
}
