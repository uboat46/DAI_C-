using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace RegistroAlumno
{
    class Conexion
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;

        public static SqlConnection Connect()
        {
            SqlConnection cnn;
            cnn = new SqlConnection("Data Source=CC201-22;Initial Catalog=RegistroAlumnosBD;Persist Security Info=True;User ID=sa;Password=sqladmin");
            cnn.Open();
            MessageBox.Show("Conexion Exitosa");
            return cnn;
        }

        public void llenarComboProgramas(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("SELECT programas.nombrePrograma FROM programas", Connect());
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

        public void llenarComboProgramas(System.Windows.Forms.ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("SELECT programas.nombrePrograma FROM programas", Connect());
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

        public int agregaAlumno(Alumno a)
        {
            try
            {
               return AlumnoCommands.agregarAlumno(a);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show(e.Message);
                return -1;
            }
        }

        public int eliminaAlumno(Alumno a)
        {
            try
            {
                return AlumnoCommands.eliminaAlumno(a);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show(e.Message);
                return -1;
            }
        }

        public void buscaAlumno(int folio, System.Windows.Forms.TextBox[] cartilla)
        {
            try
            {
                cmd = AlumnoCommands.buscaAlumno(folio);
                //cmd = new SqlCommand(String.Format("SELECT * FROM alumno WHERE alumno.folio = '{0}'", folio), Connect());
                dr = cmd.ExecuteReader();
                String[] param = { "folio", "nombre", "sexo", "mail", "semestre", "programa" };
                dr.Read();
                for (int i = 0; i < 5; i++)
                {
                    cartilla[i].Text = dr[param[i]].ToString();
                    Console.WriteLine(dr[param[i]].ToString());
                }
                Console.WriteLine(dr[param[5]].ToString());
                switch (dr[param[5]].ToString())
                {
                    case "1":
                        cartilla[5].Text = "computacion";
                        break;
                    case "2":
                        cartilla[5].Text = "telecom";
                        break;
                    case "3":
                        cartilla[5].Text = "mecatronica";
                        break;
                    case "4":
                        cartilla[5].Text = "negocios";
                        break;
                    case "5":
                        cartilla[5].Text = "industrial";
                        break;
                }
                    dr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show(e.Message);
            }
        }
    }

    
}
