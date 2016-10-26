using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace primerEjemploBD
{
    class Conexion
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Conexion()
        {
            try
            {
                cnn = new SqlConnection("Data Source=CC201-22;Initial Catalog=Ejemplo1;User ID=sa;Password=sqladmin");
                cnn.Open();
                MessageBox.Show("Se realizó la conexion");
            }catch(Exception e) 
            {
                Console.WriteLine(e.Message);
                MessageBox.Show(e.Message);
            }
        }

        public void llenarComboProgramas(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("SELECT programas.nombreProgramas FROM programas", cnn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cb.Items.Add(dr["nombreProgramas"].ToString());
                }

                dr.Close();
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show(e.Message);
            }
        }
    }
    
}
