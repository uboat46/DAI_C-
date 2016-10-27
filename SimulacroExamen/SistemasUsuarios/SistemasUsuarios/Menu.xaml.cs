using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace SistemasUsuarios
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        private int id;
        public Menu(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow main_frm = new MainWindow();
            main_frm.Show();
        }

        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            Conexion con = new Conexion();
            con.llenaComboUsers(cb_users);
            MessageBox.Show(id.ToString());
        }

    }
}
