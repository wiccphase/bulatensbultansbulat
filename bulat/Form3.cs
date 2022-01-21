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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form2  frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            string hotel = "MIKLAGORD HOTEL";
            Form8 frm8 = new Form8();
            frm8.Show();
            frm8.qweasd.Text = "Выбранный отель:" + hotel;

            //frm8.qweasd1.Image = Image.FromFile("C:/Users/Ade1/source/repos/bulat/bulat/img/MiklagordHotel.jpg");
            frm8.qweasd1.Image = Properties.Resources._1;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string hotel = "MEGARON HOTEL";
            Form8 frm8 = new Form8();
            frm8.Show();
            frm8.qweasd.Text = "Выбранный отель:" + hotel;

           
            frm8.qweasd1.Image = Properties.Resources._2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string hotel = "AKGUN ISTANBUL HOTEL";
            Form8 frm8 = new Form8();
            frm8.Show();
            frm8.qweasd.Text = "Выбранный отель:" + hotel;


            frm8.qweasd1.Image = Properties.Resources._3;
        }
    }
}
