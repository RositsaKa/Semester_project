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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Window
    {
        public MainPage()
        {
            InitializeComponent();
        }



        private void Add_book(object sender, RoutedEventArgs e)
        {
            BookDevelopment sth = new BookDevelopment();
            sth.Show();
            this.Close();
        }

        private void Show_bookcase(object sender, RoutedEventArgs e)
        {
            Bookcase bc = new Bookcase();
            bc.Show();
            this.Close();
        }
        private void People(object sender, RoutedEventArgs e)
        {
            Users s = new Users();
            s.Show();
            this.Close();
        }
    }
}
