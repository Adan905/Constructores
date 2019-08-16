using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores2
{
    class Contactos
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }

        public Contactos()
        {
            Nombre = "Sin Nombre";
            Celular = "Sin celular";
            Telefono = "Sin teléfono";
            Correo = "Sin correo";
            Direccion = "Sin dirección";
        }

        public Contactos(string nombre, string correo)
        {
            Nombre = nombre;
            Correo = correo;
            Celular = "Sin celular";
            Telefono = "Sin teléfono";
            Direccion = "Sin direccion";
        }

        public Contactos(string nombre, string celular, 
            string telefono, string correo,
            string direccion)
        {

        }
    }
}
