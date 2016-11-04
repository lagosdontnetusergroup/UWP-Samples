using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Tip_Calculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        double tipPercentage;
        public MainPage()
        {
            this.InitializeComponent();
            List<string> items = new List<string>();
            items.Add("5");
            items.Add("10");
            items.Add("15");
            items.Add("20");
            items.Add("25");
            PercentageCombo.ItemsSource = items;
            PercentageCombo.SelectedIndex = 0;
            tipPercentage = double.Parse(PercentageCombo.SelectedItem.ToString());
            AmountBox.Text = "1";
        }

        private void AmountBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (AmountBox.Text!="")
                CalculateTip();
        }


        private void CalculateTip()
        {
            double baseAmount = double.Parse(AmountBox.Text);
            var tipAmount = baseAmount *( tipPercentage/100);
            var totalAmount = baseAmount + tipAmount;
            TipAmountBox.Text = tipAmount.ToString();
            TotalAmountBox.Text = totalAmount.ToString();
            
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            tipPercentage = double.Parse(PercentageCombo.SelectedItem.ToString());
            CalculateTip();
        }
    }
}
