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
    /// Interaction logic for AddParent.xaml
    /// </summary>
    public partial class AddParent : Window
    {   IBL bl;
        public AddParent(IBL bl_)
        {
            InitializeComponent();
            bl = bl_;
        }
        private void CreateParent(object sender, RoutedEventArgs e)
        {
            Gender gen = (DP.Gender)Enum.Parse(typeof(DP.Gender), Gender.Text);
            Origin orig = (DP.Origin)Enum.Parse(typeof(DP.Origin), Origin.Text);
            Parent parent = bl.AddparentToDAL(FirstName.Text, LastName.Text, MiddleName.Text, gen, orig, int.Parse(SeekerId.Text));
            MessageBox.Show("The parent was added successfully!" + "\n" + parent.ToString(), "Operation Succeeded", MessageBoxButton.OK);

        }
    }
}
