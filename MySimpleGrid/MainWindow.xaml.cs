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
using static System.Net.Mime.MediaTypeNames;


namespace MySimpleGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User addUsers = new User();

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            addUsers.FirstName = textbox_fname.Text;
            addUsers.LastName = textbox_lname.Text;
            addUsers.BirthOfDate = (DateTime)date_birth.SelectedDate;
            addUsers.City = select_city.Text;

            
            dataUsers.Items.Add(addUsers);
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void textbox_fname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        

        private void textbox_lname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void select_city_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

    public class User
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? BirthOfDate { get; set; }
        public string? City { get; set; }
    }


}
