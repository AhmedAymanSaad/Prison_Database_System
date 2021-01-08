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
    public partial class GuardAssignments : Form
    {
        Controller controllerObj;
        Form MyParent;
        public GuardAssignments(Form P)
        {
            InitializeComponent();
            MyParent = P;
            MyParent.Hide();
            controllerObj = new Controller();

            DataTable dt = controllerObj.SelectFacilityNo();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "SectorID";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetGuardAssignments();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetGuardCountInSector();
            
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetGuardCountInSectorNo(int.Parse(comboBox1.Text.ToString()));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
