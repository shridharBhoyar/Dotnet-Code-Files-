using DatabaseFirst_Enumration.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseFirst_Enumration
{
    public partial class Form1 : Form
    {

        int id = 0;

        student model = new student();
        DatabaseFirstDbEntities db = new DatabaseFirstDbEntities();

        public Form1()
        {

            InitializeComponent();
            bingriviw();
            reset();
        }

       void bingriviw()
        {
            dataGridView1.DataSource = db.students.ToList<student>();
        }

       private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
       {
          id= Convert.ToInt32( dataGridView1.SelectedRows[0].Cells[0].Value);
           model=db.students.Where( x =>x.id==id).FirstOrDefault();
           textBox1.Text = model.name;
             textBox2.Text=model.gender;
             textBox3.Text = model.age.ToString();
             textBox4.Text =  model.stander.ToString();
       }

       private void button1_Click(object sender, EventArgs e)
       {
           model.name = textBox1.Text;
           model.gender= textBox2.Text;
           model.age = Convert.ToInt32( textBox3.Text);
           model.stander = Convert.ToInt32 (textBox4.Text);

           db.students.Add(model);
           int a=db.SaveChanges();
           if(a>0)
           {
               MessageBox.Show("data inserted");
               bingriviw();
               reset();
           }
           else
           {
               MessageBox.Show("data not inserted");
              
           }
       }

         void reset()
       {
             textBox1.Clear();
             textBox2.Clear();
             textBox3.Clear();
             textBox4.Clear();
       }

         private void button2_Click(object sender, EventArgs e)
         {
             model.id = id;
             model.name = textBox1.Text;
             model.gender = textBox2.Text;
             model.age = Convert.ToInt32(textBox3.Text);
             model.stander = Convert.ToInt32(textBox4.Text);


             db.Entry(model).State = EntityState.Modified;
             int a = db.SaveChanges();
             if (a > 0)
             {
                 MessageBox.Show("data  updeted");
                 bingriviw();
                 reset();
             }
             else
             {
                 MessageBox.Show("data not updated");

             }
         }

         private void button3_Click(object sender, EventArgs e)
         {
             DialogResult dr = MessageBox.Show("are you shoure","Alrt",MessageBoxButtons.YesNo);
             if(dr==DialogResult.Yes)
             {

             }
         }
    }
}
