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
    public partial class GuardView : Form
    {
        public GuardView()
        {
            InitializeComponent();
        }

        private void GuardView_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuardAssignments g = new GuardAssignments(this);
            g.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VisitorData v = new VisitorData(this);
            v.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InmateData f = new InmateData(this);
            f.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            GuardRelation a = new GuardRelation(this);
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LogIn l = new LogIn();
            l.Show();
            this.Hide();
        }
    }
}
