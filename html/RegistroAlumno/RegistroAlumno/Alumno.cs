using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAlumno
{
    class Alumno
    {
        public int folio{ get;set;}
        public int semestre { get; set; }
        public int ingenieria { get; set; }
        public String nombre { get; set; }
        public String sexo { get; set; }
        public String correo { get; set; }

        public Alumno()
        { 
        }

        public Alumno(int fol, String nom, String sex, String mail,int sem,int ing)
        {
            folio = fol;
            nombre = nom;
            sexo = sex;
            correo = mail;
            semestre = sem;
            ingenieria = ing;
        }
    }
}
