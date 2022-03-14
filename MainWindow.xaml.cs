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

namespace INTRALINK_WPF_GUI_1
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

        

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        // LOGIN CONDITION TREBA UBACIT PODATKE IZ BAZE UMJESTO BADZE
        // ZAMJENIT PLACEHOLDER WRONG PASSWORD SCREEN I DODAT RETURN UMJESTO CLOSEA (Amer)
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(UserName.Text == "admin" && PasswordField.Password == "admin")
            {
                new AdminPanel().Show();
                this.Hide();
            }
            else if(UserName.Text == "badzo" && PasswordField.Password == "badzo123")
            {
                new UserPanel().Show();
                this.Hide();
            }
            else
            {
                new WrongPassword().Show();
                this.Hide();
            }
        }

        private void UserName_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.Close();
        }
    }
}
