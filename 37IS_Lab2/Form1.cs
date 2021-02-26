using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _37IS_Lab2
{
    public partial class Form1 : Form
    {
        private string ed_time;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strMessage = "";
            if (radioButton1.Checked == true)
            {
                strMessage = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                strMessage = radioButton2.Text;
            }
            else if (radioButton3.Checked == true)
            {
                strMessage = radioButton3.Text;
            }

            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Вы выбрали " + strMessage);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 fm6 = new Form6();
            fm6.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 fm7 = new Form7();
            fm7.Show();
        }
    }
}
