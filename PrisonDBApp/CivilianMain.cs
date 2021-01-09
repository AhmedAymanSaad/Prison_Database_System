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
    public partial class Civ_ViewBoard : Form
    {
        public Civ_ViewBoard()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Sign_Up_Button_Click(object sender, EventArgs e)
        {
            CivSignUpForm a = new CivSignUpForm(this);
            a.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            InfoUpdateForm a = new InfoUpdateForm(this);
            a.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            VisitForm a = new VisitForm(this);
            a.Show();
        }
    }
}
