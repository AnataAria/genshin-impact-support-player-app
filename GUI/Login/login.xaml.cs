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
using GENSHIN_IMPACT_SP_APP.DB.DB_MODEL;
using GENSHIN_IMPACT_SP_APP.GUI.Register.client;
using GENSHIN_IMPACT_SP_APP.GUI.genshin_interface;

namespace GENSHIN_IMPACT_SP_APP.GUI.Login
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {
        login_manage manage = new login_manage();
        
        public login()
        {
            InitializeComponent();
        }

        private void loggin_btn_Click(object sender, RoutedEventArgs e)
        {
            String userName = username.Text;
            String passWord = password.Password;
            manage.loadData(userName, passWord);

            if (manage.checkUserPass() == true)
            {
                MessageBox.Show("Welcome to Genshin Impact");
                client_interface user = new client_interface(userName);
                Visibility = Visibility.Collapsed;
                user.ShowDialog();
                
            }
        }

        private void register_btn_Click(object sender, RoutedEventArgs e)
        {
            client_register registerWindows = new client_register();
            registerWindows.ShowDialog();
            this.Close();
        }

        private void developerInfo_btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
