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
    /// Interaction logic for NewUser.xaml
    /// </summary>
    public partial class NewUser : Window
    {
        IBL bl = BLFactory.GetBL();

        User myUser = new User();//יוזר ריק

        public NewUser(IBL bl_)
        {
            InitializeComponent();
            bl = bl_;
        }

        private void bNewUser_Click(object sender, RoutedEventArgs e)
        {
            if ((tbNewUser.Text != null) && (tbEmail.Text != null) && (pbPass.Password == pbPassNewUser.Password))
            {
                myUser.UserName = tbNewUser.Text;//ערך הטקטס של טיביוזר נכנס לתוך היוזרניימ
                myUser.Email = tbEmail.Text;
                myUser.Password = pbPass.Password;
                try
                {
                    bl.AddUser(myUser);
                    this.Close();
                }
                catch (UserException ex)
                {
                    MessageBox.Show(ex.Message + ex.InnerException, "Operation Failure", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (pbPass.Password != pbPassNewUser.Password)
            {
                MessageBox.Show("The password doesn't match the password confirm");
            }
            else if (bl.GetUser(tbNewUser.Text, pbPass.Password) != null)
            {
                MessageBox.Show("The username exists ");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
