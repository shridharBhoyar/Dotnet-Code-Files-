using Entityframwork.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Entityframwork
{
    public partial class Form1 : Form
    {
        int Id = 0;
        Employee model = new Employee();
        DatabaseContex1  db = new DatabaseContex1();

        public Form1()
        {
            InitializeComponent();
            bindgridviw();
        }

       

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            model.name = textBox1.Text;
            model.gender = textBox2.Text;
            model.age = Convert.ToInt32( textBox3.Text);
            model.designation = textBox4.Text;
            db.Emplployees.Add(model);
            int a=db.SaveChanges();
            if(a>0)
            {
                MessageBox.Show("insreted");
                bindgridviw();
                clar();
            }
            else
            {
                MessageBox.Show("not insrt");
            }
        }
        void bindgridviw()
        {
            dataGridView1.DataSource = db.Emplployees.ToList<Employee>();
        }

        void clar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            model = db.Emplployees.Where(x => x.id == Id).FirstOrDefault();
            textBox1.Text = model.name;
            textBox2.Text = model.gender;
            textBox3.Text = (model.age).ToString();
            textBox4.Text = model.designation;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            model = db.Emplployees.Where(x => x.id == Id).FirstOrDefault();

            model.id = Id;
            model.name=textBox1.Text;
            model.gender = textBox2.Text;
            model.age = Convert.ToInt32( textBox3.Text);
            model.designation = textBox4.Text;
            db.Entry(model).State = EntityState.Modified;
            int a =db.SaveChanges();

            if (a > 0)
            {
                MessageBox.Show("updated");
                bindgridviw();
                clar();
            }
            else
            {
                MessageBox.Show("not updsted");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("are you shore delete data","Alert",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
           if(dr==DialogResult.Yes)
           {
               model = db.Emplployees.Where(x => x.id == Id).FirstOrDefault();
               db.Entry(model).State = EntityState.Deleted;
             int a=   db.SaveChanges();
               if (a > 0)
               {
                   MessageBox.Show("deleted");
                   bindgridviw();
                   clar();
               }
               else
               {
                   MessageBox.Show("not deleted");
               }
               

           }
            else
           {
               MessageBox.Show("Cancel ");
           }
            

        }
    }
}
