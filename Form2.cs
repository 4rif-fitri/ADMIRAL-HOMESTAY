using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMIRAL_HOMESTAY
{

    public partial class Form2 : Form
    {
        private string address;
        private int idx = 0;
        private double[] listHarga = {100.00,200.00,300.00};
        private string[] listRumah = {"Homestay1", "Homestay2", "Homestay3" };

        private int dayStart;
        private int dayEnd;
        public Form2(string address)
        {
            InitializeComponent();
            this.address = address;
            dateStart.MinDate = DateTime.Today;
            dateEnd.MinDate = DateTime.Today;

            dateStart.Value = DateTime.Today;
            dateEnd.Value = DateTime.Today;

            dayStart = dateStart.Value.Day;
            dayEnd = dateEnd.Value.Day;

            render();
        }

        public void render(){
            inpAddress.Text = address;
            picBoxHome.Image = imgListHome.Images[idx];
            labelHome.Text = listRumah[idx];
            labelRate.Text = listHarga[idx].ToString("F2");
            labelDays.Text = (dayEnd - dayStart).ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (idx == imgListHome.Images.Count - 1) idx = -1;
            idx++;
            render();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (idx == 0) idx = imgListHome.Images.Count;
            idx--;
            render();

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double total = listHarga[idx] * (dayEnd - dayStart);
            labelTotal.Text = $"RM{total.ToString("F2")}";
        }

        private void dateEnd_ValueChanged(object sender, EventArgs e)
        {
            dayEnd = dateEnd.Value.Day;
            render();
        }

        private void dateStart_ValueChanged_1(object sender, EventArgs e)
        {
            dayStart = dateStart.Value.Day;
            render();
////www
        }
    }
}
