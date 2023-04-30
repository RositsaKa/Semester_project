using System;
using System.Collections.Generic;
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
    /// Interaction logic for BookDevelopment.xaml
    /// </summary>
    public partial class BookDevelopment : Window
    {
        public BookDevelopment()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-HB92ERE;Initial Catalog=Books;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void Book_1(object sender, RoutedEventArgs e)
        {
            sqlCon.Open();
            string query = "Insert into Books (title, author, genra, place,status, notes) values('" + this.txtTitle.Text + "','" + this.txtAuthor.Text + "','" + this.txtGenra.Text + "','" + txtPlace.Text + "','" + this.txtStatus.Text + "','" + this.txtNotes.Text + "')";
            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
            sqlCmd.ExecuteNonQuery();

            All sth = new All();
            sth.Show();
            this.Close();


        }
        private void Update(object sender, RoutedEventArgs e)
        {
            sqlCon.Open();
            string query = "UPDATE Books set title = '" + this.txtTitle.Text + "',author = '" + this.txtAuthor.Text + "', genra = '" + this.txtGenra.Text + "', place = '" + this.txtPlace.Text + "', status = '" + this.txtStatus.Text + "', notes = '" + this.txtNotes.Text + "' WHERE title= '" + this.txtTitle.Text + "'";
            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
            sqlCmd.ExecuteNonQuery();

            All sth = new All();
            sth.Show();
            this.Close();

        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            sqlCon.Open();
            string query = "DELETE from Books WHERE title = '" + this.txtTitle.Text + "'";
            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
            sqlCmd.ExecuteNonQuery();

            All sth = new All();
            sth.Show();
            this.Close();
        }
    }
}
