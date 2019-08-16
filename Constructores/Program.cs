using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Contado contado1 = new Contado();
            contado1.Nombre = "Jose";
            contado1.Celular = "(644) 00 00 004";
            contado1.Correo = "jose@gmail.com";

            Console.WriteLine(
                "Nombre: " + contado1.Nombre);
            Console.WriteLine(
                "Correo: " + contado1.Correo);
            Console.WriteLine(
                "Direccion: " + contado1.Direccion);
            Console.WriteLine(
                "Celular: " + contado1.Celular);
            Console.WriteLine( 
               "Telefono: " + contado1.Telefono);

            Contado contado2 =
                new Contado("Juan", "Juan@gmail.com", "64401544", "1441541", "casacasasas");
            Console.WriteLine("Contado 2");
            Console.WriteLine(
                "Nombre: " + contado2.Nombre);
            Console.WriteLine(
                "Correo: " + contado2.Correo);
            Console.WriteLine(
                "Direccion: " + contado2.Direccion);



            Console.Read();
        }
    }
}
