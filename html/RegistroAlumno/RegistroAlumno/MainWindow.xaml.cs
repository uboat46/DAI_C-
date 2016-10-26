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

namespace RegistroAlumno
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String sexo = rdBtn_hombre.IsChecked == true ? "masculino":"femenino";
            int prog = 0;
            if (tb_folio.Text != "" && tb_nombre.Text != "" && tb_correo.Text != "" && tb_semestre.Text != "")
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

                Alumno a = new Alumno(int.Parse(tb_folio.Text), tb_nombre.Text, sexo, tb_correo.Text, int.Parse(tb_semestre.Text), prog);

                tb_folio.Text = "";
                tb_nombre.Text = "";
                tb_correo.Text = "";
                tb_semestre.Text = "";
                cb_programa.SelectedIndex = 0;

                Conexion con = new Conexion();
                int res = con.agregaAlumno(a);
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

       
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Conexion con = new Conexion();
            con.llenarComboProgramas(cb_programa);
        }

        private void cb_programa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btn_elimina_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Elimina elimina_frm = new Elimina();
            elimina_frm.Show();

        }

        private void start()
        {
            InitializeComponent();
        }

        private void btn_modifica_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Modifica modifica_frm = new Modifica();
            modifica_frm.Show();
        }

        private void btn_busca_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Busca busca_frm = new Busca();
            busca_frm.Show();
        }

        private void tb_folio_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
