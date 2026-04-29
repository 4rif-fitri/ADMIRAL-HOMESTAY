using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMIRAL_HOMESTAY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelNatio.Visible = false;
            inpNationality.Visible = false;
            labelPassport.Visible = false;
            inpPassport.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inpName.Text))
            {
                MessageBox.Show("Enter Name");
                return;
            }
            else if (string.IsNullOrWhiteSpace(inpAddress.Text))
            {
                MessageBox.Show("Enter Address");
                return;
            }
            else if (string.IsNullOrWhiteSpace(inpPhoneNumber.Text))
            {
                MessageBox.Show("Enter Contact Number");
                return;
            }

            if (cbIsMalaysian.Checked)
            {
                if (string.IsNullOrWhiteSpace(inpNationality.Text))
                {
                    MessageBox.Show("Enter Nationality");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(inpPassport.Text))
                {
                    MessageBox.Show("Enter Passport");
                    return;
                }
            }

            string address = inpAddress.Text.ToString();

            var form2 = new Form2(address);
            form2.Show();
            this.Visible = false;
        }

        private void cbIsMalaysian_CheckedChanged(object sender, EventArgs e)
        {

            if (cbIsMalaysian.Checked)
            {
                labelNatio.Visible = true;
                inpNationality.Visible = true;
                labelPassport.Visible = true;
                inpPassport.Visible = true;

            }
            else
            {
                labelNatio.Visible = false;
                inpNationality.Visible = false;
                labelPassport.Visible = false;
                inpPassport.Visible = false;
            }
        }
    }
}
