using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bulat
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hotel = "Luxembourg Hotel ";
            Form8 frm8 = new Form8();
            frm8.Show();
            frm8.qweasd.Text = "Выбранный отель:" + hotel;


            frm8.qweasd1.Image = Properties.Resources._4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string hotel = "MEGARON HOTEL";
            Form8 frm8 = new Form8();
            frm8.Show();
            frm8.qweasd.Text = "Выбранный отель:" + hotel;


            frm8.qweasd1.Image = Properties.Resources._5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string hotel = "Lerontes Hotel";
            Form8 frm8 = new Form8();
            frm8.Show();
            frm8.qweasd.Text = "Выбранный отель:" + hotel;


            frm8.qweasd1.Image = Properties.Resources._6;
        }
    }
}
