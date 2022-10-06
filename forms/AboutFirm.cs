using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoExam
{
    public partial class AboutFirm : Form
    {
        public AboutFirm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HelpFirm newForm = new HelpFirm();
            newForm.Show();
            Hide();
        }

        private void AboutFirm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Время " + DateTime.Now.ToLongTimeString().ToString() + "      Дата: " + DateTime.Now.ToShortDateString().ToString();
        }
    }
}
