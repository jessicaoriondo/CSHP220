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
using System.Text.RegularExpressions;
namespace Homework4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            uxSubmitButton.IsEnabled = false;
        }

        private void uxZipChanged(object sender, TextChangedEventArgs e)
        
        {
            //US zip pattern ##### or #####-####
            string USzip = @"^\d{5}(?:[-]\d{4})?$";

            //Canada zip pattern A#B#C#
            string Canadazip = @"^[a-zA-Z][0-9][a-zA-Z][0-9][a-zA-Z][0-9]$";

            if (Regex.Match(uxZip.Text, USzip).Success || Regex.Match(uxZip.Text, Canadazip).Success)
            {
                uxSubmitButton.IsEnabled = true;
            }
            else {
                uxSubmitButton.IsEnabled = false;
            }
            
        }
    }
}
