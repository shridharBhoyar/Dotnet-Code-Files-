using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace Email_Send
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                MailMessage mm = new MailMessage(textBox1.Text, textBox2.Text, textBox3.Text, textBox6.Text);
                mm.Attachments.Add(new Attachment(textBox7.Text.ToString()));
                SmtpClient client = new SmtpClient(comboBox1.SelectedItem.ToString());
                client.Port = 587;
                client.Credentials = new NetworkCredential(textBox4.Text, textBox5.Text);
                client.EnableSsl = true;
                client.Send(mm);
                MessageBox.Show("mail sent");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" +ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "select files ";
            of.Filter = " All files (*.* ) | *.*";
            of.ShowDialog();
            
            if(of.ShowDialog()==DialogResult.OK)
            {
                string path = of.FileName.ToString();
                textBox7.Text = path;
            }
        }
    }
}
