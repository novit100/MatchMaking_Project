using BL;
using DP;
using Microsoft.Win32;
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
    /// Interaction logic for InsertingSeeker.xaml
    /// </summary>
    public partial class InsertingSeeker : Window
    {
        IBL bl;

        public InsertingSeeker(IBL bl_)
        {
            InitializeComponent();
            bl = bl_;

            DadOrigin_ComboBox.ItemsSource = Enum.GetValues(typeof(Origin));
            DadOrigin_ComboBox.SelectedIndex = 0;
            MomOrigin_ComboBox.ItemsSource = Enum.GetValues(typeof(Origin));
            MomOrigin_ComboBox.SelectedIndex = 0;
        }

        private void PictureUploadButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                SeekerImage.Source = new BitmapImage(fileUri);
            }
        }
    }
}
