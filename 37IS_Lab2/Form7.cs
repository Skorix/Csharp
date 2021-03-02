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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            labelFarTemp.Text = vScrollBar1.Value.ToString();
            labelCTemp.Text = Convert.ToString((int)(((double)vScrollBar1.Value - 32) / 9 * 5));
        }
    }
}
