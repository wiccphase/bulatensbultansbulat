using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bulat
{
    public partial class Form7 : Form
    {
        private SqlConnection sqlConnection = null;
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String Country = textBox1.Text;
            String DateDeparture = textBox2.Text;
            String ArrivalDate = textBox3.Text;
            String AmountAdults = textBox4.Text;
            String AmountChild = textBox5.Text;
            String GorodVileta = textBox6.Text;
            String Email = textBox7.Text;

            SqlCommand command = new SqlCommand($"INSERT INTO [Tours] (Country, DateDeparture, ArrivalDate, AmountAdults, AmountChild, GorodVileta, Email) VALUES (@Cou ,@DepartureD, @ArrivalD, @AmountAd, @AmountC,@GorodV, @Em)", sqlConnection);

            command.Parameters.Add("@Cou", SqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@DepartureD", SqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@ArrivalD", SqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@AmountAd", SqlDbType.VarChar).Value = textBox4.Text;
            command.Parameters.Add("@AmountC", SqlDbType.VarChar).Value = textBox5.Text;
            command.Parameters.Add("@GorodV", SqlDbType.VarChar).Value = textBox6.Text;
            command.Parameters.Add("@Em", SqlDbType.VarChar).Value = textBox7.Text;
            
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Ваша заявка принята.Ожидайте нашего ответа на почту.");
            else
                MessageBox.Show("nea");

            command.ExecuteNonQuery();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            db db = new db();
            db.GetConnection();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);

            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("ПоДКЛЮЧЕНИЕ ХАРОШ");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
    }
}

