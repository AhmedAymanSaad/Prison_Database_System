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
    public partial class Prison_Warden_Visitation : Form
    {
        Controller controllerObj;
        Form MyParent;
        int VisitationCount;
        DateTime today = DateTime.Today;
        public Prison_Warden_Visitation(Form P)

        {
            InitializeComponent();
            MyParent = P;
            MyParent.Hide();
            controllerObj = new Controller();

            DataTable dt1 = controllerObj.SelectInmateIDs();
            IDs_comboBox.DataSource = dt1;
            IDs_comboBox.DisplayMember = "ID";



        }

        private void Prison_Warden_Visitation_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectScheduledVisits(Int32.Parse(IDs_comboBox.Text));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

            VisitsScheduled_comboBox.Items.Clear();
            if (dt != null)
            {
                VisitationCount = dt.Rows.Count;
                for (int i = 1; i <= VisitationCount; i++)
                {
                    VisitsScheduled_comboBox.Items.Add(i);
                }
            }
        }

        private void Prison_Warden_Visitation_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDs_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectScheduledVisits(Int32.Parse(IDs_comboBox.Text));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();


            VisitsScheduled_comboBox.Items.Clear();
            if (dt != null)
            {
                VisitationCount = dt.Rows.Count;
                for (int i = 1; i <= VisitationCount; i++)
                {
                    VisitsScheduled_comboBox.Items.Add(i);
                }
            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            MyParent.Visible = true;
            this.Hide();
        }

        private void CancelVisit_button_Click(object sender, EventArgs e)
        {
            if (VisitsScheduled_comboBox.Text == "")
            {
                MessageBox.Show("No visits to cancel");
                return;
            }
            int cancellingVisit = controllerObj.CancelAVisit(Int32.Parse(VisitsScheduled_comboBox.Text), Int32.Parse(IDs_comboBox.Text));
            if (cancellingVisit == 1)
            {
                MessageBox.Show("The visit has been cancelled");
                DataTable dt = controllerObj.SelectScheduledVisits(Int32.Parse(IDs_comboBox.Text));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();

                VisitsScheduled_comboBox.Items.Clear();
                if (dt != null)
                {
                    VisitationCount = dt.Rows.Count;
                    for (int i = 1; i <= VisitationCount; i++)
                    {
                        VisitsScheduled_comboBox.Items.Add(i);
                    }
                }
            }
        }
    }

}
