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

namespace WPF_Basics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The descripton is : { this.DescriptionText.Text}" );
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.chkAssembly.IsChecked = this.chkWeld.IsChecked = this.chkDrill.IsChecked = this.chkFold.IsChecked = this.chkLaser.IsChecked = 
                this.chkLathe.IsChecked = this.chkPlasma.IsChecked = this.chkPurchase.IsChecked = this.chkRoll.IsChecked = this.chkSaw.IsChecked = false;

            //this.chkFold.IsChecked = false;
        }

        private void chk_Checked(object sender, RoutedEventArgs e)
        {
            this.LengthText.Text += ((CheckBox)sender).Content;
        }
    }
}
