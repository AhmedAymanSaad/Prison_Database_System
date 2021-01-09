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
    public partial class InmateData : Form
    {
        Controller controllerObj;
        Form MyParent;
        public InmateData(Form P)
        {
            InitializeComponent();
            MyParent = P;
            MyParent.Hide();
            controllerObj = new Controller();
            DataTable dt1 = controllerObj.SelectInmateIDs();
            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = "ID";
            comboBox4.DataSource = dt1;
            comboBox4.DisplayMember = "ID";
            DataTable dt2 = controllerObj.SelectSectorNo();
            comboBox2.DataSource = dt2;
            comboBox2.DisplayMember = "SectorID";
            DataTable dt3 = controllerObj.SelectJobs();
            comboBox3.DataSource = dt3;
            comboBox3.DisplayMember = "JobID";
            DataTable dt4 = controllerObj.GetInmatesNoJob();
            comboBox4.DataSource = dt4;
            comboBox4.DisplayMember = "ID";
            DataTable dt5 = controllerObj.SelectAllFacilities();
            comboBox5.DataSource = dt5;
            comboBox5.DisplayMember = "Facilitynumber";
            DataTable dt6 = controllerObj.SelectAllCellsRepaired();
            comboBox6.DataSource = dt6;
            comboBox6.DisplayMember = "Cellnumber";
        }

        private void InmateData_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllInmates();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = controllerObj.SelectInmatewithJob(int.Parse(comboBox1.Text.ToString()));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            catch { }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectJobs();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectInmateJob(int.Parse(comboBox3.Text.ToString()));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Salary_textBox.Text == "" || Job_textBox.Text == "")
            {
                MessageBox.Show("Please insert all info");
            }
            else
            {
                StringBuilder err = new StringBuilder();
                Object sal = ValidationClass.isPositiveInteger(Salary_textBox.Text, err);
                if (sal == null)
                {
                    MessageBox.Show("Some inputs has incorrect values " + err.ToString());
                }
                else
                {
                    int r = controllerObj.AssignInmateJob(int.Parse(comboBox4.Text.ToString()),int.Parse(Salary_textBox.Text),Job_textBox.Text);
                    MessageBox.Show("Operation successful!");
                    DataTable dt3 = controllerObj.SelectJobs();
                    comboBox3.DataSource = dt3;
                    comboBox3.DisplayMember = "JobID";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MyParent.Visible = true;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectInmateSector(int.Parse(comboBox2.Text.ToString()));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllFacilities();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void comboBox5_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = controllerObj.SelectFacility(int.Parse(comboBox5.Text.ToString()));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            catch { }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllCells();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = controllerObj.SelectCell(int.Parse(comboBox6.Text.ToString()));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            catch { }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Repair_textBox.Text == "")
            {
                MessageBox.Show("Please insert all info");
            }
            else
            {
                controllerObj.ReportCell(int.Parse(comboBox6.Text.ToString()),Repair_textBox.Text);
                DataTable dt6 = controllerObj.SelectAllCellsRepaired();
                comboBox6.DataSource = dt6;
                comboBox6.DisplayMember = "Cellnumber";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            StringBuilder err = new StringBuilder();
            Object exp = ValidationClass.isPositiveInteger(Expense_textBox.Text, err);
            if (exp == null)
            {
                MessageBox.Show("Some inputs has incorrect values " + err.ToString());
            }
            else
            {
                controllerObj.ReportFacility(int.Parse(comboBox5.Text.ToString()),int.Parse(Expense_textBox.Text));
                DataTable dt5 = controllerObj.SelectAllFacilities();
                comboBox5.DataSource = dt5;
                comboBox5.DisplayMember = "Facilitynumber";
            }
        }
    }
}
