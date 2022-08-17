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

        public MainWindow(IBL bl_)
        {
            InitializeComponent();
            bl = bl_;
        }

        private void AddNewButton_Click(object sender, RoutedEventArgs e)
        {
            InsertingSeeker myInsertingSeekerWindow = new InsertingSeeker(bl);
            myInsertingSeekerWindow.Show();
            this.Close();
        }
    }
}

