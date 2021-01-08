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
    public partial class VisitorData : Form
    {
        Controller controllerObj;
        Form MyParent;
        public VisitorData(Form P)
        {
            InitializeComponent();
            MyParent = P;
            MyParent.Hide();
            controllerObj = new Controller();
            DataTable dt = controllerObj.GetVisitors();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "National_ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetVisitors();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetVisitorVisits(int.Parse(comboBox1.Text.ToString()));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetVisitorRelations(int.Parse(comboBox1.Text.ToString()));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
