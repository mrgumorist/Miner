﻿using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Serialization;

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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string str= null;
            foreach (var item in Class1.results)
            {
                str += item+'\n';
            }
            MessageBox.Show(str);
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {

            Class1.results.Clear();
        }

            private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<string>));
                using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, Class1.results);
                }
            }
            catch
            {

            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<string>));

            try
            {
                using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
                {
                    Class1.results = (List<string>)formatter.Deserialize(fs);

                }
            }
            catch
            {

            }

        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Hidden;
             Window2 objMainWindow = new Window2(NameOfUser);
             objMainWindow.ShowDialog();
             Visibility = Visibility.Visible;
           // MessageBox.Show("Вибачте! Цей варіант гри стане доступний в майбутньому!");


        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Hidden;
            Thirt objMainWindow = new Thirt(NameOfUser);
            objMainWindow.ShowDialog();
            Visibility = Visibility.Visible;
        }
    }
}
