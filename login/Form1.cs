using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace login
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = connectionservice.getConnection();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (login(textUsername.Text, textPassword.Text))
            {
                Form2 welcome = new Form2();
                welcome.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tidak berhasil");
            }
        }

        public Boolean login(String sUsername, String sPassword)
        {
            string SQL = "SELECT username, password FROM akun";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(SQL, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if ((sUsername == reader.GetString(0) && (sPassword == reader.GetString(1))))
                {
                    string jeneng = sUsername;
                    conn.Close();
                    return true;
                }
            }
            conn.Close();
            return false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void regButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd;
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO akun values(@username, @password)";
                cmd.Parameters.AddWithValue("@username", textUsername.Text);
                cmd.Parameters.AddWithValue("@password", textPassword.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}