using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Puerta
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Puerta p = new Puerta();
            Console.WriteLine("Valores iniciales...");
            p.MostrarEstado();

            Console.WriteLine();

            Console.WriteLine("Vamos a abrir y a cambiar el ancho por 80...");
            p.Abrir();
            p.SetAncho(80);
            p.MostrarEstado();

            Console.WriteLine();

            Console.WriteLine("Ahora el portón...");
            Porton p2 = new Porton();
            p2.SetAncho(300);
            p2.Bloquear();
            p2.MostrarEstado();
            */

            //Constructores

            Puerta p1 = new Puerta();
            Puerta p2 = new Puerta(80,150);

            Console.WriteLine("Valores iniciales de p1");
            p1.MostrarEstado();

            Console.WriteLine();

            Console.WriteLine("Valores iniciales de p2");
            p2.MostrarEstado();

            Console.WriteLine();

            p1.Abrir();
            p1.SetAncho(120);
            Console.WriteLine("p1 cambia el ancho y se abre");
            p1.MostrarEstado();
            Console.WriteLine();

            Porton por = new Porton();
            Console.WriteLine("Valores iniciales de Portón");
            por.MostrarEstado();
            Console.WriteLine();

            por.Bloquear();
            Console.WriteLine("Portón desbloqueado");
            por.MostrarEstado();
            Console.WriteLine();









        }
    }
}
