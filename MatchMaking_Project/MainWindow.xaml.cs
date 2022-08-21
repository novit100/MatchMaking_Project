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
        PlacesForDatesUserControl placesForDatesUC;
        AboutUserControl aboutUserControl;
        BoysDisplayUserControl boysDisplayUserControl;
        CurrentOffersUserControl currentOffersUserControl;
        //HomeUserControl homeUserControl;

        public MainWindow(IBL bl_)
        {
            InitializeComponent();
            bl = bl_;
           //homeUserControl = new HomeUserControl(bl);
           //UserControllersGrid.Children.Add(homeUserControl);
            InsertingSeekerUC = new InsertingSeekerUserControl(bl);
            placesForDatesUC = new PlacesForDatesUserControl();
            aboutUserControl = new AboutUserControl();
            boysDisplayUserControl = new BoysDisplayUserControl(bl);
            currentOffersUserControl = new CurrentOffersUserControl(bl);
        }

        private void AddSeeker_Click(object sender, RoutedEventArgs e)
        {
            HomeGrid.Visibility = Visibility.Collapsed;
            UserControllersGrid.Children.Clear();
            UserControllersGrid.Children.Add(InsertingSeekerUC);
        }


        private void PackIcon_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Unable to save file, try again.");
        }

        private void DatingPlacesButton_Click(object sender, RoutedEventArgs e)
        {
           HomeGrid.Visibility = Visibility.Collapsed;
            UserControllersGrid.Children.Clear();
            UserControllersGrid.Children.Add(placesForDatesUC);
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            HomeGrid.Visibility = Visibility.Collapsed;
            UserControllersGrid.Children.Clear();
            UserControllersGrid.Children.Add(aboutUserControl);
        }

        private void BoysButton_Click(object sender, RoutedEventArgs e)
        {
            HomeGrid.Visibility = Visibility.Collapsed;
            UserControllersGrid.Children.Clear();
            UserControllersGrid.Children.Add(boysDisplayUserControl);

        }

        private void OffersInProgressButton_Click(object sender, RoutedEventArgs e)
        {
            HomeGrid.Visibility = Visibility.Collapsed;
            UserControllersGrid.Children.Clear();
            UserControllersGrid.Children.Add(boysDisplayUserControl);

        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            UserControllersGrid.Children.Clear();
            HomeGrid.Visibility = Visibility.Visible;

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

