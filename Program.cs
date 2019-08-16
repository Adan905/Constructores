using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores2
{
    class Program
    {
        static void Main(string[] args)
        {
            Contactos contacto1 = new Contactos();
            contacto1.Nombre = "José";
            contacto1.Celular = "(644) 4 00 00 00";
            contacto1.Correo = "Josesito@correo.com.mx";

            Console.WriteLine(
                "Nombre: " + contacto1.Nombre);
            Console.WriteLine(
                "Correo1: " + contacto1.Correo);
            Console.WriteLine(
                "Dirección: " + contacto1.Direccion);

            Contactos contacto2 =
                new Contactos("Juan", "juaniiito@correo.com");
            Console.WriteLine("Nombre: " + contacto2.Nombre);
            Console.WriteLine(
                "Correo" + contacto2.Nombre);
            Console.WriteLine("Dirección: " +
                contacto2.Direccion);

            Console.Read();
        
           ;
        }
    }
}
