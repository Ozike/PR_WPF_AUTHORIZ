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
using WPF_FITNESS_CENTER.Model;

namespace WPF_FITNESS_CENTER
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAuthorization_Click(object sender, RoutedEventArgs e)
        {
            string login = txtBoxLogin.Text;
            string password = txtBoxPassword.Password;
            Hash.Hash hash = new Hash.Hash();
            Helper helper = new Helper();
            Entities database = Helper.GetContext();
            if (login == "")
            {
                if (password == "")
                {
                    MessageBox.Show("Введите логин и пароль");
                }
                else
                {
                    MessageBox.Show("Введите логин");
                }
            }
            else if (password == "")
            {
                MessageBox.Show("Введите пароль");
            }
            else
            {
                password = hash.hashing(password);
                string result = helper.SearchUsers(login, password);
                MessageBox.Show(result);
            }
        }
    }
}
