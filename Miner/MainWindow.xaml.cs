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

namespace Miner
{
   
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string NameOfUser;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Hidden;
            Window1 objMainWindow = new Window1(NameOfUser);
            objMainWindow.ShowDialog();
            Visibility = Visibility.Visible;
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            NameOfUser = textBox1.Text;
        }
    }
}
