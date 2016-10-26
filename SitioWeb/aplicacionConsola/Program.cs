using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aplicacionConsola.ServiceReference1;
namespace aplicacionConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo!");
            aplicacionConsola.ServiceReference1.miServicioWebSoapClient ws = new miServicioWebSoapClient();
            int a, b, c;
            for (int i = 0; i < 1000; i++)
            {
                a = i;
                for (int j = 2; j < 5000; j++)
                {
                    b = j;
                    c = ws.suma(a, b);
                    Console.WriteLine("La suma de " + a + " y " + b + " es = " + c);
                }
            }


            Console.ReadKey();
        }
    }
}
