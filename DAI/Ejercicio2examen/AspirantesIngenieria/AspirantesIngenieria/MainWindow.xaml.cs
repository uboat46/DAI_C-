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

namespace AspirantesIngenieria
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String sexo = radioH.IsChecked == true ? "masculino" : "femenino";
            String gradoStr = radio1.IsChecked == true ? "4" : radio2.IsChecked == true ? "5" : "6";
            int grado = int.Parse(gradoStr);
            String fechaNac = dt_fecha.SelectedDate.ToString();
            int prog = 0;
            if (tb_nombre.Text != "" && tb_correo.Text != "" && dt_fecha.SelectedDate.ToString() != "")
            {

                switch (cb_programa.SelectedItem.ToString().Trim())
                {
                    case "computacion":
                        prog = 1;
                        break;
                    case "telecom":
                        prog = 2;
                        break;
                    case "mecatronica":
                        prog = 3;
                        break;
                    case "negocios":
                        prog = 4;
                        break;
                    case "industrial":
                        prog = 5;
                        break;
                    default:
                        Console.WriteLine("No entro a ningun selector");
                        break;
                }

                Aspirante a = new Aspirante(tb_nombre.Text, sexo, fechaNac, tb_correo.Text, grado, prog);

                tb_nombre.Text = "";
                tb_correo.Text = "";
                cb_programa.SelectedIndex = 0;

                Conexion con = new Conexion();
                int res = con.agregaAspirante(a);
                if (res > 0)
                {
                    MessageBox.Show("Alumno Dado de ALTA");

                }
                else
                {
                    MessageBox.Show("Alumno NO Dado de ALTA");
                }
            }
            else
            {
                MessageBox.Show("Porfavor Rellene todos los campos");
            }
        }

        private void main_Loaded(object sender, RoutedEventArgs e)
        {
            Conexion con = new Conexion();
            con.llenarComboProgramas(cb_programa);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Modifica elimina_frm = new Modifica();
            elimina_frm.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Elimina elimina_frm = new Elimina();
            elimina_frm.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Reporte elimina_frm = new Reporte();
            elimina_frm.Show();
        }

    }
}
