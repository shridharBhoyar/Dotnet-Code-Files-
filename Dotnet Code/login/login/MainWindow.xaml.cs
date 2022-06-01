using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             SqlConnection con = new SqlConnection("Data Source=DESKTOP-UBUQ9EJ;Initial Catalog=Inventry_System;Integrated Security=True");
             string quary = "select * from SingUp where Email=@user and Password=@pass  ";
             SqlCommand cmd = new SqlCommand(quary,con);
             cmd.Parameters.AddWithValue("@user",usernam.Text);
             cmd.Parameters.AddWithValue("@pass", pass.Text);
            con.Open();
             SqlDataReader dr= cmd.ExecuteReader();

            if(dr.HasRows)
            {
                MessageBox.Show("inserted");
            }
            else
            {
                MessageBox.Show(" not inserted");
            }
            con.Close();
        }
    }
}
