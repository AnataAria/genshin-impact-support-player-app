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
using GENSHIN_IMPACT_SP_APP.DB.DB_MANAGE;

namespace GENSHIN_IMPACT_SP_APP.GUI.Login
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }

        private void loggin_btn_Click(object sender, RoutedEventArgs e)
        {
            String userName = username.Text;
            String passWord = password.Password;
            if (userName.Length != 0 || passWord.Length != 0)
            {
                if (userName.ToLower().Equals("anataarisa") && passWord.Equals("Vinh12345.")){
                    MessageBox.Show("Welcome to genshin impact");
                }
            }
        }
    }
}
