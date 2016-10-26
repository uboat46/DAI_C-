using System;
using System.Collections.Generic;
using System.Data.Odbc;
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

namespace AspirantesIngenieria
{
    /// <summary>
    /// Lógica de interacción para Modifica.xaml
    /// </summary>
    public partial class Modifica : Window
    {
        public Modifica()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow main_frm = new MainWindow();
            main_frm.Show();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Conexion con = new Conexion();
            con.llenarComboAspirante(cb_aspirante);
            con.llenarComboProgramas(cb_programa);
        }

        private void cb_aspirante_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SqlConnection con = Conexion.Connect();

            if (con != null)
            {

                String user = cb_aspirante.SelectedValue.ToString();
                if (user != "")
                {
                    String query = "SELECT aspirante.correo,aspirante.grado,programa.nombrePrograma FROM aspirante INNER JOIN programa ON programa.idPrograma = aspirante.idIngenieria WHERE aspirante.nombre = '" +user+"'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        tb_correo.Text = dr["correo"].ToString();
                        switch (dr["grado"].ToString())
                        {
                            case "4": radio1.IsChecked = true;
                                break;
                            case "5": radio2.IsChecked = true;
                                break;
                            case "6": radio3.IsChecked = true;
                                break;
                        }
                        cb_programa.SelectedValue = dr["nombrePrograma"];
                    }
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("NO SE ESTABLECIO LLENADO DEL GRID \n (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻  |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| ");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SqlConnection con = Conexion.Connect();

            if (con != null)
            {

                String user = cb_aspirante.SelectedValue.ToString();
                if (user != "" && tb_correo.Text != "" && cb_programa.SelectedValue.ToString() != "")
                {
                    String gradoStr = radio1.IsChecked == true ? "4" : radio2.IsChecked == true ? "5" : "6";
                    int prog = 0;
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

                    String query = "UPDATE aspirante SET aspirante.correo = '" + tb_correo.Text + "',aspirante.idIngenieria = '" + prog + "',aspirante.grado = '" + gradoStr + "' WHERE aspirante.nombre ='" + user + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    int res = cmd.ExecuteNonQuery();
                    if(res > 0)  MessageBox.Show("SE dio exitosamente la mod"); else MessageBox.Show("No se dio de la mod");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("NO SE ESTABLECIO LLENADO DEL GRID \n (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻  |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| ");
            }
        }
    }
}
