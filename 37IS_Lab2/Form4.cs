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
    public partial class Form4 : Form
    {
        private int progress=0;
        Random rnd = new Random();
        Color cr = new Color();

        public Form4()
        {
            InitializeComponent();
            label2.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sbros();
            switch (Convert.ToString(listBox1.SelectedItem))
            {
                default:
                    timer1.Interval = 1000;  
                    break;
                case "Минуты":
                    timer1.Interval = 60000;
                    break;
                case "Часы":
                    timer1.Interval = 3600000;
                    break;

            }
            if ((Convert.ToInt32(numericUpDown1.Value) == 17))
            {
                label2.Visible = true;
            }
            timer1.Interval = (timer1.Interval * Convert.ToInt32(numericUpDown1.Value))/100;
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.ForeColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            progressBar1.Value++;
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                MessageBox.Show("Win");
            }
            
        }

        private void sbros()
        {
            progressBar1.Value = 0;
            timer1.Enabled = false;
            timer2.Enabled = false;
            qwe = 0;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            sbros();  
        }
        public int qwe = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            qwe++;
            label1.Text = Convert.ToString(qwe);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 fm5 = new Form5();
            fm5.Show();
        }

    }
}
