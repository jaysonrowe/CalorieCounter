using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using CalorieCounter.Resources;

namespace CalorieCounter
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double height = Convert.ToDouble(txtHeight.Text) * 2.54;
            double weight = Convert.ToDouble(txtWeight.Text) / 2.2;
            int age = Convert.ToInt32(txtAge.Text);
            double malecal = ((10 * weight) + (6.25 * height) - (5 * age) + 5);
            double femalecal = ((10 * weight) + (6.25 * height) - (5 * age) - 161);
     

            if (cboxMale.IsChecked == true)
            {
                if (btnAct0.IsChecked == true)
                {
                    string malecal0 = (malecal * 1.3).ToString();
                    caloriesNeededTxt.Text = malecal0 + " Calories Needed";
                }
                else if (btnAct1.IsChecked == true)
                {
                    string malecal1 = (malecal * 1.4).ToString();
                    caloriesNeededTxt.Text = malecal1 + " Calories Needed";
                }
                else if (btnAct2.IsChecked == true)
                {
                    string malecal2 = (malecal * 1.5).ToString();
                    caloriesNeededTxt.Text = malecal2 + " Calories Needed";
                }
                else if (btnAct3.IsChecked == true)
                {
                    string malecal3 = (malecal * 1.6).ToString();
                    caloriesNeededTxt.Text = malecal3 + " Calories Needed"; 
                }
                else if (btnAct4.IsChecked == true)
                {
                    string malecal4 = (malecal * 1.8).ToString();
                    caloriesNeededTxt.Text = malecal4 + " Calories Needed";
                }
                else
                {
                    caloriesNeededTxt.Text = "Please Select Activity Level";
                }
            }

            if (cboxFemale.IsChecked == true)
            {
                if (btnAct0.IsChecked == true)
                {
                    string femalecal0 = (femalecal * 1.3).ToString();
                    caloriesNeededTxt.Text = femalecal0 + " Calories Needed";
                }
                else if (btnAct1.IsChecked == true)
                {
                    string femalecal1 = (femalecal * 1.4).ToString();
                    caloriesNeededTxt.Text = femalecal1 + " Calories Needed";
                }
                else if (btnAct2.IsChecked == true)
                {
                    string femalecal2 = (femalecal * 1.5).ToString();
                    caloriesNeededTxt.Text = femalecal2 + " Calories Needed";
                }
                else if (btnAct3.IsChecked == true)
                {
                    string femalecal3 = (femalecal * 1.6).ToString();
                    caloriesNeededTxt.Text = femalecal3 + " Calories Needed";
                }
                else if (btnAct4.IsChecked == true)
                {
                    string femalecal4 = (femalecal * 1.8).ToString();
                    caloriesNeededTxt.Text = femalecal4 + " Calories Needed";
                }
                else
                {
                    caloriesNeededTxt.Text = "Please Select Activity Level";
                }
            }         
        }

        private void txtHeight_Click(object sender, RoutedEventArgs e)
        {
            txtHeight.Text = string.Empty;
        }

        private void txtWeight_Click(object sender, RoutedEventArgs e)
        {
            txtWeight.Text = string.Empty;
        }

        private void txtAge_Click(object sender, RoutedEventArgs e)
        {
            txtAge.Text = string.Empty;
        }
    }
}