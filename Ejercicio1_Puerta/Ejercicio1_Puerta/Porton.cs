using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Puerta
{
    class Porton:Puerta
    {
        bool bloqueada;


        public void Bloquear()
        {
            bloqueada = true;
        }
        public void Desbloquear()
        {
            bloqueada = false;
        }

        public new void MostrarEstado()
        {
            Console.WriteLine("Portón.");
            Console.WriteLine("Bloqueada: " + bloqueada);
            //Al poner los atrib. de Puerta como protegidos ya hay acceso a ellos desde Porton

            Console.WriteLine("Ancho: {0}", ancho);
            Console.WriteLine("Alto: {0}", alto);
            Console.WriteLine("Color: {0}", color);
            Console.WriteLine("Abierta: {0}", abierta);


        }

    }
}
