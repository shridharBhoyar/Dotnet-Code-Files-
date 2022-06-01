using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FertilizerProject
{
    public partial class Form1 : Form
    {
        Purchase p = new Purchase();
        PurchaseList pl = new PurchaseList();
        Sale s = new Sale();
        saleList sl = new saleList();
        Stock st = new Stock();
        Custustomer c = new Custustomer();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (p.IsDisposed == true)
            {
                p = new Purchase();
            }
            p.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (s.IsDisposed == true)
            {
                s = new Sale();
            }
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (c.IsDisposed == true)
            {
                c = new Custustomer();
            }
            c.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (st.IsDisposed == true)
            {
                st = new Stock();
            }
            st.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pl.IsDisposed == true)
            {
                pl = new PurchaseList();
            }
            pl.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(sl.IsDisposed==true)
            {
                sl = new saleList();
            }
            sl.Show();
        }
    }
}
