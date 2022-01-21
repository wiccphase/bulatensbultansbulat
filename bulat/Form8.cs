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
    public partial class Form8 : Form
    {
        public Form8()
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
            if (!checkBox1.Checked == false && !checkBox2.Checked == false)
                {
                MessageBox.Show("Спасибо за заказ. Ожидайте.");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Согласитесь с публично офертой и обработкой персональных данных");
            }

        }
    }
}
