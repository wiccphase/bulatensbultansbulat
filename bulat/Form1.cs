using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace bulat
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db db = new db();
            db.GetConnection();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);

            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("ÁÀÇÀ ÄÀÍÍÛÕ ÏÎÄÊËÞ×ÅÍÀ ÕÀÐÎØ ÊÀÐÒÀ ÌÅÃÀ ÕÀÐÎØ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String loginuser = textBox1.Text;
            String passUser = textBox2.Text;

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM Users where login = @log AND password = @pas", sqlConnection);
            command.Parameters.Add("@log", SqlDbType.VarChar).Value = loginuser;
            command.Parameters.Add("@pas", SqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();


            }
            else
                MessageBox.Show("íå õàðîø ");

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
            this.Hide();
        }
    }
}