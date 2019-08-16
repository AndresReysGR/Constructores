using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Contado
    {
        public string Nombre { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        
        public Contado()
        {
            Nombre = "Sin nombre";
            Celular = "Sin Celular";
            Telefono = "Sin telefono";
            Correo = "Sin correo";
            Direccion = "Sin direccion";
        }

        public Contado(string nombre, string correo, string celular, string telefono, string direccion)
        {
            Nombre = nombre;
            Correo = correo;
            Celular = "Sin Celular";
            Telefono = "Sin telefono";
            Direccion = "Sin direccion";
        }


    }
}
