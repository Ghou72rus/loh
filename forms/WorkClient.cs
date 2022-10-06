using DemoExam.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoExam
{
    public partial class WorkClient : Form
    {
        public WorkClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Время " + DateTime.Now.ToLongTimeString().ToString() + "      Дата: " + DateTime.Now.ToShortDateString().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Refistration newForm = new Refistration();
            newForm.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list_of_client newForm = new list_of_client();
            newForm.Show();
            Hide();
        }
    }
}
