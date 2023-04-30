using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Shapes;


namespace Semester_Project
{
    /// <summary>
    /// Interaction logic for Living.xaml
    /// </summary>
    public partial class Living : Window
    {
        public Living()
        {
            InitializeComponent(); 
            Reload_Datagrid();
        }

        private void Reload_Datagrid()
        {
            string dbsCon = @"Data Source=DESKTOP-HB92ERE;Initial Catalog=Books;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection sqlCon_ = new SqlConnection(dbsCon);

            try
            {
                sqlCon_.Open();
                string query = "Select * from Books where place='living'";
                SqlCommand cmd = new SqlCommand(query, sqlCon_);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                LivingRoomBook.ItemsSource = dt.DefaultView;

                MessageBox.Show("Successful loading");
                sqlCon_.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
