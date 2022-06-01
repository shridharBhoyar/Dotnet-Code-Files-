using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Progressbarsreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            Thread s = new Thread(new ThreadStart(runwin));
            s.Start();
            Thread.Sleep(10000);
            

            InitializeComponent();
            s.Abort();

        }

         public void runwin()
        {
            Application.Run(new Progressbar());
        }

    }
}
