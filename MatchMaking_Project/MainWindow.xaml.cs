using BL;
using DP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace MatchMaking_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IBL bl = BLFactory.GetBL();
        User curUser;

        public MainWindow()
        {
            InitializeComponent();
           if (bl.HowManyUsers() >= 2)
            {
               // btSighup
            }

        }
        
       
        private void bLogIn_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if ((pbPass.Password != "") && (tbUser.Text != ""))//if one or two of the fields are empty
                {
                    bool flag = false;
                    curUser = bl.GetUser(tbUser.Text, pbPass.Password);
                 //   if (curUser.UserStatus == BO.UserStatuses.Admine)
                     //   flag = true;
                   // MainWindow myMainWindow = new MainWindow(flag);
                    //myMainWindow.Show();
                    this.Close();

                }
            }
            catch (UserException ex)//if it didn't find the user
            {

                MessageBox.Show(ex.Message + ex.InnerException, "Operation Failure", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btSighup_Click(object sender, RoutedEventArgs e)
        {
            NewUser newUserWin = new NewUser();
            newUserWin.Show();
        }


    }
}

