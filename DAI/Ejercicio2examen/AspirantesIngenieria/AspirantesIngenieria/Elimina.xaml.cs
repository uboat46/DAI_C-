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

namespace AspirantesIngenieria
{
    /// <summary>
    /// Lógica de interacción para Elimina.xaml
    /// </summary>
    public partial class Elimina : Window
    {
        public Elimina()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Conexion con = new Conexion();
            con.llenarComboAspirante(cb_aspirante);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow main_frm = new MainWindow();
            main_frm.Show();
        }

        private void cb_aspirante_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            if (cb_aspirante.HasItems && cb_aspirante.SelectedItem.ToString() != "")
            {
                String aspi = cb_aspirante.SelectedItem.ToString().Trim();
                Aspirante a = new Aspirante(aspi, "sexo","2016-10-14", "mail", 4, 1);
                Conexion con = new Conexion();
                int res = con.eliminaAspirante(a);
                cb_aspirante.Items.Clear();
                con.llenarComboAspirante(cb_aspirante);
                if (res > 0)
                {
                    MessageBox.Show("Aspirante Dado de Baja");

                }
                else
                {
                    MessageBox.Show("Aspirante NO Dado de Baja");
                }
            }
            else
            {
                MessageBox.Show("Porfavor Rellene todos los campos");
            }
        }
    }
}
