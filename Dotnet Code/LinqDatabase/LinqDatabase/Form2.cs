using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
namespace LinqDatabase
{
    public partial class Form2 : Form
    {
        DataClasses1DataContext db;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
            ISingleResult<spstudentResult> obj = db.spstudent(null);
            dataGridView1.DataSource = obj;

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                MessageBox.Show("please filll");
            }
            else
            {
                db = new DataClasses1DataContext();
                ISingleResult<spstudentResult> resul = db.spstudent(int.Parse(textBox1.Text));
                dataGridView1.DataSource = resul;
            }
        }
    }
}
