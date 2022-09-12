using BL;
using DP;
using MatchMaking_Project.VM;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for InsertingSeekerUserControl.xaml
    /// </summary>
    public partial class InsertingSeekerUserControl : UserControl
    {
        IBL bl;
        ObservableCollection<Sibiling> SibilingsObservableCollection;
        ObservableCollection<Acquaintance> AcquaintancseObservableCollection;

        public InsertingSeekerUserControl()
        {
            InitializeComponent();
            bl = BLFactory.GetBL();
            DataContext = new insertSeekerVM();
            SibilingsObservableCollection = new ObservableCollection<Sibiling>();

            DadOrigin_ComboBox.ItemsSource = Enum.GetValues(typeof(Origin));
            DadOrigin_ComboBox.SelectedIndex = 0;
            MomOrigin_ComboBox.ItemsSource = Enum.GetValues(typeof(Origin));
            MomOrigin_ComboBox.SelectedIndex = 0;
            Torah_Study_Status_listbox.ItemsSource = Enum.GetValues(typeof(Torah_Study_Status));
            Torah_Study_Status_listbox.SelectedIndex = 0;
            Girl_Working_status_listbox.ItemsSource= Enum.GetValues(typeof(Girl_Working_status));
            Girl_Working_status_listbox.SelectedIndex = 0;
            //PersonalStatus_listbox.ItemsSource = Enum.GetValues(typeof(PersonalStatus));
            //PersonalStatus_listbox.SelectedIndex = 0;
            Interests_listbox.ItemsSource = Enum.GetValues(typeof(Interest));
            // Interests_listbox.SelectedIndex = 0;
            YeshivaG_Seminary_Combobox.ItemsSource = Enum.GetValues(typeof(YeshivaGedola));

           //// SibilingsListBox.ItemsSource = SibilingsObservableCollection;

           
        }

   
        
        ///Add
     
        private void AddSibilin_Click(object sender, RoutedEventArgs e)
        {
            int age = 0;
            Int32.TryParse(SiblinAgeTextBox.Text, out age);

            Sibiling sibiling = new Sibiling() { Gender = (BoyOrGirlSiblin.SelectedItem as Gender?), Age = age, FirstName = SiblinFirstNameTextBox.Text };
            SibilingsObservableCollection.Add(sibiling);
        }

        private void AddAcquaintance_Click(object sender, RoutedEventArgs e)
        {
            int age = 0;
            Int32.TryParse(SiblinAgeTextBox.Text, out age);

            Acquaintance acquaintance = new Acquaintance();
            AcquaintancseObservableCollection.Add(acquaintance);
        }
        //Delete
        private void DeleteSibling_Click(object sender, RoutedEventArgs e)
        {
            SibilingsObservableCollection.Remove((sender as Button).DataContext as Sibiling);

        }

        private void DeleteAcquaintance_Click(object sender, RoutedEventArgs e)
        {
            AcquaintancseObservableCollection.Remove((sender as Button).DataContext as Acquaintance);
        }

      

        //הכנסת אינם לתוך ערל יהיה באופן הבא:
        //שם הקומבובוקס נקודה סלקטד אייטם 
        // SeekerBoy.Y=(Gender) ComboBoxName.SelectedItem;

    }
}
