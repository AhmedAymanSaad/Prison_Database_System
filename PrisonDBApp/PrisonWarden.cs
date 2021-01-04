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
    public partial class PrisonWarden : Form
    {
        public PrisonWarden()
        {
            InitializeComponent();
        }

        private void Form_for_HiringAndFiring_Button_Click(object sender, EventArgs e)
        {
            Prison_Warden___Hiring_And_Firing_Guards a = new Prison_Warden___Hiring_And_Firing_Guards();
            a.Show();
        }
    }
}
