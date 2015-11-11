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

namespace webshopAdmin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            lewebshopEntities DB = new lewebshopEntities();

            UserProfile testuser = new UserProfile();
            
            LoginUser testloginuser = new LoginUser();
            testloginuser.id = 000001;
            testloginuser.name = "woodlive";
            testloginuser.pass = "1234";

            testuser.LoginUser = testloginuser;
            testuser.id = 1;
            testuser.Email = "blabla@bmail.com";

            DB.UserProfiles.Add(testuser);

            DB.SaveChanges();

            lblVigtig.Content = testuser.Email;
        }
    }
}
