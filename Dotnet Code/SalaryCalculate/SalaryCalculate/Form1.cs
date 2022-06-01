using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculate
{
    public partial class jivan : Form
    {
        public jivan()
        {
            InitializeComponent();
        }

        private void bptextBox4_TextChanged(object sender, EventArgs e)
        {
            int con, md, hr,it,gr,net;
            int bscic_pay =( Convert.ToInt32( bptextBox4.Text));

           

            if(bscic_pay >= 40000)
            {
                con = (int)(bscic_pay * 0.40);
                md=(int)(bscic_pay*0.30);
                hr=(int)(bscic_pay*0.20);

                gr = con + md + hr + bscic_pay;

                ctextBox5.Text = con.ToString();
                mtextBox6.Text = md.ToString();
                hrtextBox7.Text = hr.ToString();
                gptextBox8.Text = gr.ToString();

                if (gr >= 60000)
                {
                    it = (int)(gr * 0.03);
                    net = gr - it;

                    nstextBox10.Text = net.ToString();
                    ittextBox9.Text = it.ToString();

                }
                else if(gr>=50000)
                {
                    it=(int)(gr*0.02);
                    net = gr - it;

                    ittextBox9.Text = it.ToString();
                    nstextBox10.Text = net.ToString();
                }
            }
            else if(bscic_pay>= 30000)
            {
                con = (int)(bscic_pay * 0.35);
                md = (int)(bscic_pay * 0.25);
                hr = (int)(bscic_pay * 0.15);

                gr = con + md + hr + bscic_pay;

                ctextBox5.Text = con.ToString();
                mtextBox6.Text = md.ToString();
                hrtextBox7.Text = hr.ToString();
                gptextBox8.Text = gr.ToString();

                 if(gr>=60000)
                   {
                       it = (int)(gr * 0.03);
                       net = gr - it;
                     
                       ittextBox9.Text = it.ToString();
                       nstextBox10.Text = net.ToString();
                
                    }
                else if(gr>=50000)
                 {
                    it=(int)(gr*0.02);
                    net = gr - it;
                    ittextBox9.Text = it.ToString();
                    nstextBox10.Text = net.ToString();
                }
            }
            else if(bscic_pay<30000)
            {


                ctextBox5.Text = "3000";
                mtextBox6.Text = "2000";
                hrtextBox7.Text = "1000";



            }
            
            
        }


    }
}
