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
    public partial class HelpFirm : Form
    {
        public HelpFirm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = "Время " + DateTime.Now.ToLongTimeString().ToString() + "      Дата: " + DateTime.Now.ToShortDateString().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AboutFirm newForm = new AboutFirm();
            newForm.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AboutBrigads newForm = new AboutBrigads();
            newForm.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PriceList newForm = new PriceList();
            newForm.Show();
            Hide();
        }
    }
}
