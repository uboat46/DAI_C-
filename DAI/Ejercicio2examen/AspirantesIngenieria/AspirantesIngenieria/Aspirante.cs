using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspirantesIngenieria
{
    class Aspirante
    {
        public int grado { get; set; }
        public int ingenieria { get; set; }
        public String fechaNac { get; set; }
        public String nombre { get; set; }
        public String sexo { get; set; }
        public String correo { get; set; }

        public Aspirante()
        { 
        }

        public Aspirante(String nom, String sex,String fec, String mail,int gra,int ing)
        {
            nombre = nom;
            fechaNac = fec;
            sexo = sex;
            correo = mail;
            grado = gra;
            ingenieria = ing;
        }

        public String convierteFecha()
        {
            String aux = fechaNac;
            String año = aux.Substring(6, 4);
            String dia = aux.Substring(0, 2);
            String mes = aux.Substring(3, 2);
            aux = año + "-" + mes + "-" + dia;
            return aux;
        }
    }
}
