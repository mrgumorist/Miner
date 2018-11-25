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

namespace Miner
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        // 0-nema minu 10-mine 
        string NameOfUser;
        int[,] Mass = new int[5,5];
        Button[,] MassButton = new Button[5, 5];
        Random random = new Random();
        public Window1(string NameOfUser)
        {
            this.NameOfUser = NameOfUser;
            for (int i = 0; i < 5; i++)
            {
                for(int j=0; j<5; j++)
                {
                    Mass[i,j] = 0;
                }
            }
            int countofmin = 5;
            while(countofmin != 0)
            {
                bool ChiYE=false;
                while (ChiYE == false)
                {
                    int x = Class1.RandomTo5();
                    int y = Class1.RandomTo5();
                    if(Mass[x,y]!=10)
                    {
                        Mass[x, y] = 10;
                        ChiYE = true;
                    }
                }
                countofmin--;
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(Mass[i,j]!=10)
                    {
                        try
                        {
                            if(Mass[i-1,j]==10)
                            {
                                Mass[i, j]++;
                            }
                        }
                        catch 
                        {

                           
                        }
                        try
                        {
                            if (Mass[i - 1, j-1] == 10)
                            {
                                Mass[i, j]++;
                            }
                        }
                        catch
                        {


                        }
                        try
                        {
                            if (Mass[i, j - 1] == 10)
                            {
                                Mass[i, j]++;
                            }
                        }
                        catch
                        {


                        }
                        try
                        {
                            if (Mass[i, j + 1] == 10)
                            {
                                Mass[i, j]++;
                            }
                        }
                        catch
                        {


                        }
                        try
                        {
                            if (Mass[i-1, j + 1] == 10)
                            {
                                Mass[i, j]++;
                            }
                        }
                        catch
                        {


                        }
                        try
                        {
                            if (Mass[i + 1, j - 1] == 10)
                            {
                                Mass[i, j]++;
                            }
                        }
                        catch
                        {


                        }
                        try
                        {
                            if (Mass[i+1, j] == 10)
                            {
                                Mass[i, j]++;
                            }
                        }
                        catch
                        {


                        }
                        try
                        {
                            if (Mass[i + 1, j + 1] == 10)
                            {
                                Mass[i, j]++;
                            }
                        }
                        catch
                        {


                        }
                    }
                }
                
            }
            InitializeComponent();
        }
        public int countEnabled()
        {
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (MassButton[i, j].IsEnabled == true)
                    {
                        count ++;
                    }
                }
            }
            return count;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (countEnabled() > 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if ((sender as Button) == MassButton[i, j])
                        {
                            if (Mass[i, j] != 10 && Mass[i, j] != 0)
                            {
                                MassButton[i, j].Content = Mass[i, j];
                                MassButton[i, j].IsEnabled = false;
                            }
                            else if (Mass[i, j] == 0)
                            {
                                MassButton[i, j].IsEnabled = false;
                            }
                            else
                            {
                                for(int k=0; k<5; k++)
                                {
                                    for (int l = 0; l < 5; l++)
                                    {
                                        if(Mass[k,l]==10)
                                        {
                                            MassButton[k, l].Content ="*" ;
                                            MassButton[k, l].IsEnabled = false;
                                        }
                                        else if(Mass[k, l] == 0)
                                        {
                                            MassButton[k, l].IsEnabled = false;
                                        }
                                        else
                                        {
                                            MassButton[k, l].Content = Mass[k, l];
                                            MassButton[k, l].IsEnabled = false;
                                        }
                                    }
                                }
                                MessageBox.Show("You lose");
                                this.Close();
                                break;
                                
                            }
                        }
                    }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("You win");
                this.Close();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int x = 0, y = 0;
            foreach (var item in kek.Children)
            {
                if (item is Button)
                {

                    if (x < 5)
                    {
                        MassButton[x, y] = item as Button;
                        x++;
                    }
                    else
                    {
                        x = 0; y++;
                        MassButton[x, y] = item as Button;
                        x++;
                    }
                }
            }
            //MessageBox.Show("MassButton");
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (Mass[i, j] == 10)
            //        {
            //            MassButton[i, j].Content = "*";
            //        }
            //        else
            //        {
            //            MassButton[i, j].Content = Mass[i, j];
            //        }
            //    }
            //}

        }
       

    }
}
