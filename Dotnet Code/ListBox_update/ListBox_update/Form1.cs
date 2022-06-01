using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_update
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
            }
            catch
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(a);
            listBox1.Items.Insert(a, textBox1.Text);
        }
    }
}
