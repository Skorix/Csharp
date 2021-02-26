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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            while (memberList.CheckedIndices.Count > 0)
            {
                memberList.Items.RemoveAt(memberList.CheckedIndices[0]);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (peopleList.Text.Length != 0)
            {
                memberList.Items.Add(peopleList.Text);
            }
            else
            { 
                MessageBox.Show("Выберите элемент в списке для ввода или введите новый.");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.Show();
        }
    }
}

