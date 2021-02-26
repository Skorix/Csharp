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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // добавляем новый элемент в список
            listView1.Items.Add(textBox1.Text, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // получаем выделенный узел
            TreeNode node = treeView1.SelectedNode;
            // если выделенного узла нет
            if (node == null)
            {   // добавляем новый элемент
                // в корень основного дерева
                treeView1.Nodes.Add(textBox1.Text);
            }
            // если имеется выделенный узел
            else
            {   // добавляем новый элемент
                // как вложенный в выделенный узел
                node.Nodes.Add(textBox1.Text);
            }

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //Form1 fm1 = new Form1();
            //fm1.Size = new Size(Convert.ToInt32(Label.text), Convert.ToInt32(Label.text));
        }
    }
}