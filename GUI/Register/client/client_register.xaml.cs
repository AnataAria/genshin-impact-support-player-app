using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using System.Xml.Serialization;
using GENSHIN_IMPACT_SP_APP.Tool.Validate;
using GENSHIN_IMPACT_SP_APP.GUI.Login;
using GENSHIN_IMPACT_SP_APP.DB.DB_MANAGE;
using GENSHIN_IMPACT_SP_APP.DB.DB_MODEL;

namespace GENSHIN_IMPACT_SP_APP.GUI.Register.client
{
    /// <summary>
    /// Interaction logic for client_register.xaml
    /// </summary>
    public partial class client_register : Window
    {
        private String Username;
        private String Password;
        private register_model Re_model;
        public client_register()
        {
            InitializeComponent();
            hideBtnGrid();
        }

        private void hideBtnGrid()
        {
            hideButton();
            hideGrid();
        }

        private void hideButton()
        {
            AccInfo_btn.Visibility = Visibility.Collapsed;
            DetailInfo_btn.Visibility = Visibility.Collapsed;
            CharacterInfo_btn.Visibility = Visibility.Collapsed;
        }

        private void hideGrid()
        {
            basicInfo_Grid.Visibility = Visibility.Collapsed;
            DetailInfo_Grid.Visibility = Visibility.Collapsed;
            AccountInfo_Grid.Visibility = Visibility.Collapsed;
            CharacterInfo_Grid.Visibility = Visibility.Collapsed;
        }

        private void BasicInfo_btn_Click(object sender, RoutedEventArgs e)
        {
            if (basicInfo_Grid.IsVisible == false)
            {
                basicInfo_Grid.Visibility = Visibility.Visible;
            }
            else
            {
                hideGrid();
            }
        }

        private void AccInfo_btn_Click(object sender, RoutedEventArgs e)
        {
            if(AccountInfo_Grid.IsVisible == false)
            {
                AccountInfo_Grid.Visibility = Visibility.Visible;
            }
            else
            {
                hideGrid();
            }
        }

        private void DetailInfo_btn_Click(object sender, RoutedEventArgs e)
        {
            if(DetailInfo_Grid.IsVisible == false)
            {
                DetailInfo_Grid.Visibility = Visibility.Visible;
            }
            else
            {
                hideGrid();
            }
        }
        private void CharacterInfo_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_btn_Click(object sender, RoutedEventArgs e)
        {
            login login = new login();
            login.ShowDialog();
            this.Close();
            
        }

        private void ToAccDetail_btn_Click(object sender, RoutedEventArgs e)
        {
            String username_temp;
            String password_temp;
            String repass_temp;
            if (AccInfo_btn.IsVisible == false)
            {
                AccInfo_btn.Visibility = Visibility.Visible;
                AccountInfo_Grid.Visibility = Visibility.Visible;
                username_temp = usernames.Text;
                password_temp = passwords.Text;
            }
            else
            {
                AccInfo_btn.Visibility = Visibility.Collapsed;
                AccountInfo_Grid.Visibility= Visibility.Collapsed;
            }
        }

        private void Register_btn_Click(object sender, RoutedEventArgs e)
        {
            register_model Register = new register_model();

            
        }
    }
}
