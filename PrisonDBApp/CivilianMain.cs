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
        Controller controllerObj;
        int Username;
        Form MyParent;
        public Civ_ViewBoard(int UN, Form P)
        {
            InitializeComponent();
            Username = UN;
            controllerObj = new Controller();
            MyParent = P;
            MyParent.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Sign_Up_Button_Click(object sender, EventArgs e)
        {
            CivSignUpForm a = new CivSignUpForm(this);
            if (controllerObj.CheckIfRegistered(Username) == 1)
            {
                MessageBox.Show("You are already registered!");
            }
            else
            a.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            InfoUpdateForm a = new InfoUpdateForm(Username, this);
            a.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            VisitForm a = new VisitForm(this, Username);
            if (controllerObj.CheckIfRegistered(Username) == 0)
            {
                MessageBox.Show("You must register a visitor first");
            }
            else
            {
                a.Show();
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            CivChangePassword a = new CivChangePassword(Username, this);
            a.Show();
        }

        private void RegisterVisitorButton_Click(object sender, EventArgs e)
        {
            CivRegisterVisitorFormcs a = new CivRegisterVisitorFormcs(Username, this);
            
            a.Show();
        }

        private void CheckPersonStatusButton_Click(object sender, EventArgs e)
        {
            CheckPersonStatusForm a = new CheckPersonStatusForm(this);
            a.Show();
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            CivCheckSentence a = new CivCheckSentence(this);
            a.Show();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            LogIn l = new LogIn();
            l.Show();
            this.Hide();
        }
    }
}
