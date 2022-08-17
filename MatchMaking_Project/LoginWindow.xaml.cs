using BL;
using DP;
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

namespace MatchMaking_Project
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        IBL bl = BLFactory.GetBL();
        User curUser;

        public LoginWindow()
        {
            InitializeComponent();
            if (bl.HowManyUsers() >= 2)
            {
                TextBlockSignup.Visibility = Visibility.Hidden;
                btSighup.IsEnabled = false;
                btSighup.Visibility = Visibility.Hidden;
            }
            else
            {
                TextBlockSignup.Visibility = Visibility.Visible;
                btSighup.IsEnabled = true;
                btSighup.Visibility = Visibility.Visible;
            }

        }


        private void bLogIn_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if ((pbPass.Password != "") && (tbUser.Text != ""))//if one or two of the fields are empty
                {
                    curUser = bl.GetUser(tbUser.Text, pbPass.Password);
                    /////////////////////////////////////
                    MainWindow myMainWindow = new MainWindow(bl);
                    myMainWindow.Show();
                    this.Close();

                }
            }
            catch (UserException ex)//if it didn't find the user
            {
                MessageBox.Show(ex.Message + ex.InnerException, "Operation Failure", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.InnerException, "Operation Failure", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void btSighup_Click(object sender, RoutedEventArgs e)
        {
            NewUser newUserWin = new NewUser(bl);
            newUserWin.Show();
        }

    }
}
