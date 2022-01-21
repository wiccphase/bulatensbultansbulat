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
    public partial class Form6 : Form
    {
        private SqlConnection sqlConnection = null;
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Поле логина пустое");
                return;
            }


            SqlCommand command = new SqlCommand($"INSERT INTO [Users] (login, password, nickname) VALUES (@login ,@password, @nickname)", sqlConnection);

            command.Parameters.Add("@login", SqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@nickname", SqlDbType.VarChar).Value = textBox3.Text;
            if (CheckUser())
                return;
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Да");
            else
                MessageBox.Show("nea");

            command.ExecuteNonQuery();


        }

        public Boolean CheckUser()
        {
            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM Users where login = @log", sqlConnection);
            command.Parameters.Add("@log", SqlDbType.VarChar).Value = textBox1.Text;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Логин занят");
                return true;
            }
            else
                return false;



        }
        private void Form6_Load(object sender, EventArgs e)
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
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
