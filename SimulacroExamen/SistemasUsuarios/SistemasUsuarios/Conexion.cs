using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SistemasUsuarios
{
    class Conexion
    {
        private static SqlConnection cnn;
        private SqlCommand cmd;
        private SqlDataReader dr;

        public static SqlConnection Connect()
        {
            String DB = "SistemaUsuarios";
            String maquina = "112SALAS11";
            String con = "Data Source="+maquina+";Initial Catalog="+DB+";User ID=sa;Password=sqladmin";
            cnn = new SqlConnection(con);
            cnn.Open();
            return cnn;
        }

        public void llenaComboUsers(ComboBox cb)
        {
            try
            {
                cnn = Connect();
                cmd = new SqlCommand("SELECT usuarios.usuario FROM usuarios",cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["usuario"]);
                }
                cb.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Sin usuarios");
            }
        }
    }
}
