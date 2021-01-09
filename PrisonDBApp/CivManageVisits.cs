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
        public VisitForm(Form P)
        {
            controllerObj = new Controller();
            InitializeComponent();
            MyParent = P;
            MyParent.Hide();
        }

        private void VisitForm_Load(object sender, EventArgs e)
        {

        }

        private void BookVisitButton_Click(object sender, EventArgs e)
        {
            int BookVisit;
            if (VisitInmateTextbox.Text == "" || VisitVisitortextBox.Text == "")
            {
                MessageBox.Show("Please enter the both Inmate and Visitor IDs to book");
            }
            else if (DateTime.Parse(StartDateCalendar.SelectionRange.Start.ToString()) > DateTime.Parse(EndDateCalendar.SelectionRange.Start.ToString()))
            {
                MessageBox.Show("The Start date cannot be after the end date");
            }
            else
            {
                StringBuilder err = new StringBuilder();
                Object VisitID = ValidationClass.isInteger(VisitVisitortextBox.Text, err);
                Object InmateID = ValidationClass.isInteger(VisitInmateTextbox.Text, err);
                if (VisitID == null || InmateID == null)
                {
                    MessageBox.Show("Please enter visitorID and InmateID as integer numbers");
                }
                VisitID = ValidationClass.isPositiveInteger(VisitVisitortextBox.Text, err);
                InmateID = ValidationClass.isPositiveInteger(VisitInmateTextbox.Text, err);
                if (VisitID == null || InmateID == null)
                {
                    MessageBox.Show("VisitID, InmateID cannot be negative values");
                }

                BookVisit = controllerObj.BookAVisit(Int32.Parse(VisitInmateTextbox.Text), Int32.Parse(VisitVisitortextBox.Text),
                    DateTime.Parse(StartDateCalendar.SelectionRange.Start.ToString()), DateTime.Parse(EndDateCalendar.SelectionRange.Start.ToString()));

                if (BookVisit != 0)
                {
                    MessageBox.Show("A visit has been booked succesfully!");
                }
                else if (BookVisit == 0)
                {
                    MessageBox.Show("Visit could not be booked, please check information");
                }
                
                
            }

        }

        private void StartDateCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
