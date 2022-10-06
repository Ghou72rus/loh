using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoExam
{
    public partial class Form1 : Form
    {
        String Time;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = "Время " + DateTime.Now.ToLongTimeString().ToString() + "      Дата: " + DateTime.Now.ToShortDateString().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Authorization newForm = new Authorization();
            newForm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WorkClient newForm = new WorkClient();
            newForm.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HelpFirm newForm = new HelpFirm();
            newForm.Show();
            Hide();
        }
    }
}
