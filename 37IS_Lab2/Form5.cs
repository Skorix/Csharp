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
    public partial class Form5 : Form
    {
        

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }



        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {    
                this.BackgroundImage = Image.FromFile("C:/Users/СТУДЕНТ/source/repos/sharp/37IS_Lab2/img/zima.jpg");
            }
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                this.BackgroundImage = Image.FromFile("C:/Users/СТУДЕНТ/source/repos/sharp/37IS_Lab2/img/zakat.jpg");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                this.BackgroundImage = Image.FromFile("C:/Users/СТУДЕНТ/source/repos/sharp/37IS_Lab2/img/line.jpg");
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                this.BackgroundImage = Image.FromFile("C:/Users/СТУДЕНТ/source/repos/sharp/37IS_Lab2/img/gora.jpg");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.Height = (Convert.ToInt16(numericUpDown1.Value));
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            this.Width = (Convert.ToInt32(numericUpDown2.Value));
        }

        private void Form5_SizeChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = Height;
            numericUpDown2.Value = Width;
        }
    }
}


//Form1 fm1 = new Form1();
//fm1.Size = new Size(Convert.ToInt32(Label.text), Convert.ToInt32(Label.text));