using BL;
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

namespace MatchMaking_Project
{
    /// <summary>
    /// Interaction logic for HomeUserControl.xaml
    /// </summary>
    public partial class HomeUserControl : UserControl
    {
       // BoysUserControl boysUserControl;
        public HomeUserControl(IBL bl)
        {
            InitializeComponent();
          //  BoysUserControl boysUserControl = new BoysUserControl();
          //  UserControllersGrid.Children.Add(homeUserControl);
        }

      

        private void boysHomeButton_Click(object sender, RoutedEventArgs e)
        {
        //    UserControllersGrid.Children.Clear();
        //    UserControllersGrid.Children.Add(placesForDatesUC);
        }
    }
}
