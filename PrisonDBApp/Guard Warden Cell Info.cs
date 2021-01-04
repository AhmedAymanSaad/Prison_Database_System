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
    public partial class Guard_Warden_Cell_Info : Form
    {
        Form MyParent;
        Controller controllerObj;
        public Guard_Warden_Cell_Info(Form P)
        {

            InitializeComponent();
            controllerObj = new Controller();
            MyParent = P;
            MyParent.Hide();
        }

        private void Guard_Warden_Cell_Info_Load(object sender, EventArgs e)
        {

        }

        private void CellRepairs_Button_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectCellsToBeRepaired();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            MyParent.Visible = true;
            this.Hide();
        }

        private void FacilityRepairs_Button_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectFacilitiesToBeRepaired();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
