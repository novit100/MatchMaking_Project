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
        SeekerBoy boy = new SeekerBoy();

        public InsertingSeeker(IBL bl_)
        {
            InitializeComponent();
            bl = bl_;

            DadOrigin_ComboBox.ItemsSource = Enum.GetValues(typeof(Origin));
            DadOrigin_ComboBox.SelectedIndex = 0;
            MomOrigin_ComboBox.ItemsSource = Enum.GetValues(typeof(Origin));
            MomOrigin_ComboBox.SelectedIndex = 0;
            Torah_Study_Status_listbox.ItemsSource = Enum.GetValues(typeof(Torah_Study_Status));
            Torah_Study_Status_listbox.SelectedIndex = 0;
            Girl_Working_status_listbox.ItemsSource = Enum.GetValues(typeof(Girl_Working_status));
            Girl_Working_status_listbox.SelectedIndex = 0;
            PersonalStatus_listbox.ItemsSource = Enum.GetValues(typeof(PersonalStatus));
            PersonalStatus_listbox.SelectedIndex = 0;

        }

        private void PictureUploadButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                //SeekerImage.Source = new BitmapImage(fileUri);
            }
        }
        //הכנסת אינם לתוך ערל יהיה באופן הבא:
        //שם הקומבובוקס נקודה סלקטד אייטם 
       // SeekerBoy.Y=(Gender) ComboBoxName.SelectedItem;

    }
}
