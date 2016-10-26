using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAlumno
{
    class AlumnoCommands
    {
        public static int agregarAlumno(Alumno a)
        {
            SqlConnection cnn;
            cnn = Conexion.Connect();
            SqlCommand cmd = new SqlCommand(String.Format("INSERT INTO alumno(folio,nombre,sexo,mail,semestre,programa) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",a.folio,a.nombre,a.sexo,a.correo,a.semestre,a.ingenieria),cnn);
            int res = cmd.ExecuteNonQuery();
            cnn.Close(); 
            return res;
        }

        public static int eliminaAlumno(Alumno a)
        {
            SqlConnection cnn;
            cnn = Conexion.Connect();
            SqlCommand cmd = new SqlCommand(String.Format("DELETE FROM alumno WHERE alumno.folio = '{0}'", a.folio), cnn);
            int res = cmd.ExecuteNonQuery();
            cnn.Close();
            return res;
        }

        public static SqlCommand buscaAlumno(int folio)
        {
            SqlConnection cnn;
            cnn = Conexion.Connect();
            SqlCommand cmd = new SqlCommand(String.Format("Select * FROM alumno WHERE alumno.folio = '{0}'", folio), cnn);
            return cmd;
        }

        public AlumnoCommands()
        {

        }
    }
}
