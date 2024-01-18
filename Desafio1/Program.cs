using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al catalogo telefonico");
            Console.ReadKey();
        
            Telefono tf= new Telefono("S23", "Samsung");
            tf.NumeroTelefonico = "Como estas papu?";
            
            Console.WriteLine(tf.Llamar());
            Console.ReadKey();
            string contacto = "Amigo";
            Console.WriteLine(tf.Llamar(contacto));
            Console.ReadKey();
            Console.WriteLine(tf.EnviarMensaje(tf.NumeroTelefonico, "Hola CARLOS"));
            Console.ReadKey();

            



        }
    }
}
