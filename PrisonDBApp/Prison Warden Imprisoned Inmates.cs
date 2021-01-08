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
    public partial class Prison_Warden_Imprisoned_Inmates : Form
    {
        Controller controllerObj;
        Form MyParent;
        public Prison_Warden_Imprisoned_Inmates(Form P)
        {
            InitializeComponent();
            MyParent = P;
            MyParent.Hide();
            controllerObj = new Controller();

            label11.Hide();
            label16.Hide();

            BehaviorScore_numericUpDown.Maximum = 100;
            BehaviorScore_numericUpDown.Minimum = -100;

            DataTable dt = controllerObj.SelectCellNumbersHavingLessThanThreeInmates();
            CellsAvailabe_comboBox.DataSource = dt;
            CellsAvailabe_comboBox.DisplayMember = "CellNumber";

            DataTable dt1 = controllerObj.SelectInmateIDs();
            IDs_comboBox.DataSource = dt1;
            IDs_comboBox.DisplayMember = "ID";

            DataTable dt2 = controllerObj.SelectAvailableSolitaryCellNumbers();
            SolitaryConfinement_comboBox.DataSource = dt2;
            SolitaryConfinement_comboBox.DisplayMember = "Solitarycellnumber";

        }

        private void Prison_Warden_Imprisoned_Inmates_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectInmateUsingHisID(Int32.Parse(IDs_comboBox.Text));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void MoreOptions_Button_Click(object sender, EventArgs e)
        {
            Prison_Warden_Inmates a = new Prison_Warden_Inmates(this);
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int BehaviorAdded = controllerObj.SelectBehaviourUsingID(Int32.Parse(IDs_comboBox.Text));
            int TotalBehaviorScore = BehaviorAdded + (int)BehaviorScore_numericUpDown.Value;
            if (TotalBehaviorScore > 100)
                TotalBehaviorScore = 100;
            else if (TotalBehaviorScore < 0)
                TotalBehaviorScore = 0;
            int updating = controllerObj.UpdateBehaviorScore(TotalBehaviorScore, Int32.Parse(IDs_comboBox.Text));

            if (updating == 1)
            {
                MessageBox.Show(" The behavior score is updated successfully! The new Score is "+ TotalBehaviorScore.ToString());
            }
            else
            {
                    MessageBox.Show(" The behavior score update failed");
            }

        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            MyParent.Visible = true;
            this.Hide();
        }

        private void ViewInmates_button_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllInmates();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void ChangeCells_button_Click(object sender, EventArgs e)
        {
            int ChangingCells = controllerObj.ChangeCells(Int32.Parse(CellsAvailabe_comboBox.Text),Int32.Parse(IDs_comboBox.Text));

            if (ChangingCells == 1)
            {
                MessageBox.Show(" Inmate with id " + IDs_comboBox.Text + " was transfered to cell "+ CellsAvailabe_comboBox.Text);
                DataTable dt = controllerObj.SelectCellNumbersHavingLessThanThreeInmates();
                CellsAvailabe_comboBox.DataSource = dt;
                CellsAvailabe_comboBox.DisplayMember = "CellNumber";
            }
            else
            {
                MessageBox.Show(" Inmate cell transferring failed");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void SolitaryConfinment_button_Click(object sender, EventArgs e)
        {
            string theDate = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            int Check = controllerObj.CheckIfAlreadyInSolitaryConfinement(Int32.Parse(IDs_comboBox.Text));
            if (Check != 0)
            {
                MessageBox.Show(" Inmate is already in solitary confinement");
                return;
            }
            if (Duration_textBox.Text == "")
            {
                label11.Visible = true;
                return;
            }

            int Solitary = controllerObj.ChangeToSolitaryConfinement(Int32.Parse(SolitaryConfinement_comboBox.Text),Int32.Parse(IDs_comboBox.Text),
                Convert.ToDateTime(theDate), Decimal.Parse(Duration_textBox.Text));

            if (Solitary == 1)
            {
                MessageBox.Show(" Inmate with ID " + IDs_comboBox.Text + " was transfered to Solitary cell number " + SolitaryConfinement_comboBox.Text);
                DataTable dt2 = controllerObj.SelectAvailableSolitaryCellNumbers();
                SolitaryConfinement_comboBox.DataSource = dt2;
                label11.Hide();
                SolitaryConfinement_comboBox.DisplayMember = "Solitarycellnumber";
            }
            else
            {
                MessageBox.Show(" Inmate cell transferring failed");
            }

        }

        private void UpdateSentence_button_Click(object sender, EventArgs e)
        {
            if (NewSentence_textBox.Text == "")
            {
                label16.Visible = true;
                return;
            }

            int IsSentenceChanged = controllerObj.ChangeSentence(decimal.Parse(NewSentence_textBox.Text), Int32.Parse(IDs_comboBox.Text));
            if (IsSentenceChanged == 1)
            {
                label16.Hide();
                MessageBox.Show(" Inmate with ID " + IDs_comboBox.Text + " sentence was changed to " + NewSentence_textBox.Text);
            }
            else
            {
                MessageBox.Show("Sentence wasn't changed");
            }


        }

        private void NewSentence_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void IDs_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = controllerObj.SelectInmateUsingHisID(Int32.Parse(IDs_comboBox.Text));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            catch { }
        }
    }
}
