using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspirantesIngenieria
{
    class AspiranteCMD
    {
        public static int agregarAspirante(Aspirante a)
        {
            SqlConnection cnn;
            cnn = Conexion.Connect();
            SqlCommand cmd = new SqlCommand(String.Format("INSERT INTO aspirante(nombre,sexo,fechaNac,correo,grado,idIngenieria) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", a.nombre, a.sexo, a.convierteFecha(), a.correo, a.grado, a.ingenieria), cnn);
            int res = cmd.ExecuteNonQuery();
            cnn.Close();
            return res;
        }

        public static int eliminaAspirante(Aspirante a)
        {
            SqlConnection cnn;
            cnn = Conexion.Connect();
            SqlCommand cmd = new SqlCommand(String.Format("DELETE FROM aspirante WHERE aspirante.nombre = '{0}'", a.nombre), cnn);
            int res = cmd.ExecuteNonQuery();
            cnn.Close();
            return res;
        }

    }
}
