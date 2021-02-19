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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int Value = trackBar1.Value;
            numericUpDown1.Value = Value;
            progressBar1.Value = Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int Value = (int)numericUpDown1.Value;
            trackBar1.Value = Value;
            progressBar1.Value = Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 fm4 = new Form4();
            fm4.Show();
        }
    }
}
