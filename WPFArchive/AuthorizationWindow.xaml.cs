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
using System.Windows.Shapes;

namespace WPFArchive
{   
    public partial class AuthorizationWindow : Window
    {
        DbArchiveEntities db = new DbArchiveEntities();

        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void AuthorizationClick(object sender, RoutedEventArgs e)
        {
            if(login.Text == "" || password.Password == "")
            {
                MessageBox.Show("Пустые поля!");
            }
            if(db.User.Select(i => i.Login + " " + i.Password).Contains(login.Text + " " + password.Password))
            {
                MessageBox.Show("Вы авторизованы!");
                Main main = new Main();
                main.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка логина или пароля!");
            }

        }
    }
}
