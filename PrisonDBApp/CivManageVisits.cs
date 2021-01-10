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
        int FirstDateSet = 0;
        int SecondDateSet = 0;
        public VisitForm(Form P)
        {
            controllerObj = new Controller();
            InitializeComponent();
            MyParent = P;
            MyParent.Hide();
            DataTable dt = controllerObj.GetInmateNames();
            InmateNameComboBox.DataSource = dt;
            
        }

        private void VisitForm_Load(object sender, EventArgs e)
        {

        }

        //check that the user did select a date using his mouse
        private void StartDateCalendar_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            FirstDateSet = 1;
        }

        //check that the user did select a date using his mouse
        private void EndDateCalendar_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            SecondDateSet = 1;
        }


        private void BookVisitButton_Click(object sender, EventArgs e)
        {
            int BookVisit;
            if (DateTime.Parse(StartDateCalendar.SelectionRange.Start.ToString()) > DateTime.Parse(EndDateCalendar.SelectionRange.Start.ToString()))
            {
                MessageBox.Show("The end date must be greater than the start date");
            }
            else if (VisitVisitortextBox.Text == "" || InmateNameComboBox.Text == "")
            {
                MessageBox.Show("Please enter your nationalID and the visitee's name");
            }
            else if (FirstDateSet == 0 || SecondDateSet == 0)
            {
                MessageBox.Show("Please select both dates");
            }

            BookVisit = controllerObj.InsertAVisit(InmateNameComboBox.Text, Int32.Parse(VisitVisitortextBox.Text), DateTime.Parse(StartDateCalendar.SelectionRange.Start.ToString()),
                DateTime.Parse(EndDateCalendar.SelectionRange.Start.ToString()));
            if (BookVisit == 0)
            {
                MessageBox.Show("visit could not be booked, please check data and that a visit is possible");
            }
            else
            {
                MessageBox.Show("Visit booked!");
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
            if (DateTime.Parse(StartDateCalendar.SelectionRange.Start.ToString()) > DateTime.Parse(EndDateCalendar.SelectionRange.Start.ToString()))
            {
                MessageBox.Show("The end date must be greater than the start date");
            }
            else if (VisitVisitortextBox.Text == "" || InmateNameComboBox.Text == "")
            {
                MessageBox.Show("Please enter your nationalID and the visitee's name");
            }
            else if (FirstDateSet == 0 || SecondDateSet == 0)
            {
                MessageBox.Show("Please select both dates");
            }

            UpdateVisit = controllerObj.UpdateAVisit(InmateNameComboBox.Text, Int32.Parse(VisitVisitortextBox.Text), DateTime.Parse(StartDateCalendar.SelectionRange.Start.ToString()),
                DateTime.Parse(EndDateCalendar.SelectionRange.Start.ToString()));
            if (UpdateVisit == 0)
            {
                MessageBox.Show("visit could not be updated, please check data and that a visit exists");
            }
            else
            {
                MessageBox.Show("Visit Updated!");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int DeleteVisit;
            if (DateTime.Parse(StartDateCalendar.SelectionRange.Start.ToString()) > DateTime.Parse(EndDateCalendar.SelectionRange.Start.ToString()))
            {
                MessageBox.Show("The end date must be greater than the start date");
            }
            else if (VisitVisitortextBox.Text == "" || InmateNameComboBox.Text == "")
            {
                MessageBox.Show("Please enter your nationalID and the visitee's name");
            }
            else if (FirstDateSet == 0 || SecondDateSet == 0)
            {
                MessageBox.Show("Please select both dates");
            }

            DeleteVisit = controllerObj.DeleteAVisit(InmateNameComboBox.Text, Int32.Parse(VisitVisitortextBox.Text), DateTime.Parse(StartDateCalendar.SelectionRange.Start.ToString()),
                DateTime.Parse(EndDateCalendar.SelectionRange.Start.ToString()));
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
}
