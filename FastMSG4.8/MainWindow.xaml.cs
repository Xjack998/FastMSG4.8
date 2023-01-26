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


namespace FastMSG4._8
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
        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(Riga1.Text);
        }
        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(Riga2.Text);
        }
        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(Riga3.Text);
        }
        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(Riga4.Text);
        }
        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(Riga5.Text);
        }
        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(Riga6.Text);
        }
        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(Riga7.Text);
        }
        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(Riga8.Text);
        }
        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(Riga9.Text);
        }
        private void Btn10_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(Riga10.Text);
        }
    }
}
