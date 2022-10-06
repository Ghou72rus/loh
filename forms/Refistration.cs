using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DemoExam
{
    public partial class Refistration : Form
    {
        public Refistration()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Refistration_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private  void button2_Click(object sender, EventArgs e)
        {

            String login, password, name, surname, name_firm, phone, name_file;
            login = textBox1.Text;
            password = textBox2.Text;
            name = textBox4.Text;
            surname = textBox5.Text;
            name_firm = textBox6.Text;
            phone = textBox7.Text;
            name_file = textBox8.Text;
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Firma;Trusted_Connection=True;";
            string sqlExpression = String.Format("INSERT INTO Users(role,login,password,name,surname, name_firm, phone) values('user', @login, @password, @name, @surname, @name_firm, @phone)");
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Не удалось подключиться к базе данных");
                Clear();
               
            }
            finally
            {

                if (connection.State == ConnectionState.Open)
                {
                    if (password == textBox3.Text && password != "" && textBox3.Text != ""  && name != "" && surname != "" && name_firm != "" && phone != "" && login != "")
                    {

                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        {
                            //вставка данных из формы  в базу данных
                            command.Parameters.AddWithValue("user", "user");
                            command.Parameters.AddWithValue("@login", login);
                            command.Parameters.AddWithValue("@password", password);
                            command.Parameters.AddWithValue("@name", name);
                            command.Parameters.AddWithValue("@surname", surname);
                            command.Parameters.AddWithValue("@name_firm", name_firm);
                            command.Parameters.AddWithValue("@phone", phone);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Успешная регистрация!");
                            Clear();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль");
                        textBox3.Text = "";
                    }
                    connection.Close();
                }
            }
        }
        public void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }   
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename, Encoding.UTF8);
            filename = Path.GetFileNameWithoutExtension(filename);
            textBox8.Text = filename.Split("\'");
            
        }
    }
}
