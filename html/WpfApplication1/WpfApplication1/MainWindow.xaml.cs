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

namespace WpfApplication1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            start();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void bt_calcula_Click(object sender, RoutedEventArgs e)
        {
            if (tb_num_1.Text != "" && tb_num_2.Text != "")
            {
                if (rdBt_suma.IsChecked == true)
                {
                    suma();
                }
                else
                {
                    if (rdBt_resta.IsChecked == true)
                    {
                        resta();
                    }
                    else
                    {
                        if (rdBt_multiplica.IsChecked == true)
                        {
                            multiplica();
                        }
                        else 
                        {
                            divide();
                        }

                    }
                }
                start();
            }
            else
            {
                start();
            }

        }

        private void suma()
        {
            int n1 = int.Parse(tb_num_1.Text);
            int n2 = int.Parse(tb_num_2.Text);

            lb_num_res_2.Content = (n1 + n2).ToString();
        }

        private void resta()
        {
            int n1 = int.Parse(tb_num_1.Text);
            int n2 = int.Parse(tb_num_2.Text);

            lb_num_res_2.Content = (n1 - n2).ToString();
        }

        private void multiplica()
        {
            int n1 = int.Parse(tb_num_1.Text);
            int n2 = int.Parse(tb_num_2.Text);

            lb_num_res_2.Content = (n1 * n2).ToString();
        }

        private void divide()
        {
            int n1 = int.Parse(tb_num_1.Text);
            int n2 = int.Parse(tb_num_2.Text);

            if (n2 == 0)
            {
                MessageBox.Show("Dividido entre cero!!!");
                lb_num_res_2.Content = "";
                start();
            }
            else
            { 
                lb_num_res_2.Content = (n1 / n2).ToString();
            }
        }
        private void start()
        {
            InitializeComponent();
            tb_num_1.Text = "0";
            tb_num_2.Text = "0";
           
            tb_num_1.Focus();
        }

    }
}
