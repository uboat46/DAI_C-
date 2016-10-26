using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;          

namespace AspirantesIngenieria
{
    class Conexion
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;

        public static SqlConnection Connect()
        {
            SqlConnection cnn;
            String maquina = "112SALAS13";
            cnn = new SqlConnection("Data Source="+maquina+";Initial Catalog=SistemaAspirante;Persist Security Info=True;User ID=sa;Password=sqladmin");
            cnn.Open();
            //MessageBox.Show("Conexion Exitosa");
            return cnn;
        }

        public void llenarComboProgramas(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("SELECT programa.nombrePrograma FROM programa", Connect());
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cb.Items.Add(dr["nombrePrograma"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show(e.Message);
            }
        }

        public void llenarComboAspirante(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("SELECT aspirante.nombre FROM aspirante", Connect());
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cb.Items.Add(dr["nombre"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show(e.Message);
            }
        }

        public int agregaAspirante(Aspirante a)
        {
            try
            {
                return AspiranteCMD.agregarAspirante(a);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show(e.Message);
                return -1;
            }
        }

        public int eliminaAspirante(Aspirante a)
        {
            try
            {
                return AspiranteCMD.eliminaAspirante(a);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show(e.Message);
                return -1;
            }
        }
    }
}
