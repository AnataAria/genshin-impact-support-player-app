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

namespace GENSHIN_IMPACT_SP_APP.GUI.genshin_interface
{
    /// <summary>
    /// Interaction logic for client_interface.xaml
    /// </summary>
    public partial class client_interface : Window
    {
        private String userName;
        public client_interface(String userName)
        {
            InitializeComponent();
            this.userName = userName;
            putText();
        }
        void putText()
        {
            username.Text = "Username: " + userName;
            Ar.Text = "Ar: 57";
        }
    }
}
