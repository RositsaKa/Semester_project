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
    /// Interaction logic for Bookcase.xaml
    /// </summary>
    public partial class Bookcase : Window
    {
        public Bookcase()
        {
            InitializeComponent();
        }


        private void Living_room(object sender, RoutedEventArgs e)
        {
            Living dashboard = new Living();
            dashboard.Show();
            this.Close();
        }

        private void Children(object sender, RoutedEventArgs e)
        {
            Children dashboard = new Children();
            dashboard.Show();
            this.Close();
        }

        private void All(object sender, RoutedEventArgs e)
        {
            All sth = new All();
            sth.Show();
            this.Close();
        }
    }
}
