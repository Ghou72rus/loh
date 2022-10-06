using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace DemoExam
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 newForm2 = new Form1();
            newForm2.Show();
            Hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = "Время " + DateTime.Now.ToLongTimeString().ToString() + "      Дата: " + DateTime.Now.ToShortDateString().ToString();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            String login, password;
            login = textBox1.Text;
            password = textBox2.Text;
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Firma;Trusted_Connection=True;";
            string sqlExpression = "SELECT * FROM Users WHERE login = '" + login + "' and password = '" + password + "'";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                await connection.OpenAsync();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Не удалось подключиться к базе данных");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    if (command.ExecuteScalar() != null)
                    {
                        MessageBox.Show("Успешная авторизация");
                        Form1 newForm = new Form1();
                        newForm.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }
                    connection.Close();
                }
            }
        }
    }
}
