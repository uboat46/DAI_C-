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
    /// Lógica de interacción para Reporte.xaml
    /// </summary>
    public partial class Reporte : Window
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            Conexion con = new Conexion();
            con.llenarComboProgramas(cb_programa);
            cb_programa.Items.Add("Todos");
        }

        private void cb_programa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Conexion con = new Conexion();
            con.llenaGrid(grid1,cb_programa);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow main_frm = new MainWindow();
            main_frm.Show();
        }
    }
}
