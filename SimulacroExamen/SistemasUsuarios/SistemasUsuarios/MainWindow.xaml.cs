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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SistemasUsuarios
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

        private void BtnEntrar_Click(object sender, RoutedEventArgs e)
        {
            if (tb_user.Text != "" && tb_pswd.Text != "")
            {
                String user = tb_user.Text;
                String pswd = tb_pswd.Text;
                try
                {
                    String query = String.Format("SELECT usuarios.idUser FROM usuarios WHERE usuarios.usuario = '{0}' AND usuarios.passwd = '{1}'", user, pswd);
                    SqlConnection cnn = Conexion.Connect();
                    SqlCommand cmd = new SqlCommand(query, cnn);                  
                    SqlDataReader dr = cmd.ExecuteReader();
                    int id = -1;
                    while (dr.Read())
                    {
                        id = dr.GetInt32(0);
                    }
                    dr.Close();
                    cnn.Close();
                    if (id > 0)
                    {
                        this.Hide();
                        Menu menu_frm = new Menu(id);
                        menu_frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña no validos");
                        tb_pswd.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else 
            {
                MessageBox.Show("Rellene Todos Los Campos porfavor.");
                tb_pswd.Text = "";
            }
            

        }
    }
}
