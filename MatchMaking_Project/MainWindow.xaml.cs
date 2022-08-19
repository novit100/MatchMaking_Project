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
        IBL bl;

        InsertingSeekerUserControl InsertingSeekerUC;


        public MainWindow(IBL bl_)
        {
            InitializeComponent();
            bl = bl_;

            InsertingSeekerUC = new InsertingSeekerUserControl(bl);
        }

        private void AddSeeker_Click(object sender, RoutedEventArgs e)
        {
            UserControllersGrid.Children.Clear();
            UserControllersGrid.Children.Add(InsertingSeekerUC);
        }


        private void PackIcon_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Unable to save file, try again.");
        }




        /*
        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;
            UserControllersGrid.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemHome":
                    usc = new UserControlHome();
                    UserControllersGrid.Children.Add(usc);
                    break;
                case "ItemCreate":
                    usc = new UserControlCreate();
                    UserControllersGrid.Children.Add(usc);
                    break;
                default:
                    break;
            }
        }
        */



        /*
        private void AddNewButton_Click(object sender, RoutedEventArgs e)
        {
            InsertingSeeker myInsertingSeekerWindow = new InsertingSeeker(bl);
            myInsertingSeekerWindow.Show();
            this.Close();
        }
        */
    }
}

