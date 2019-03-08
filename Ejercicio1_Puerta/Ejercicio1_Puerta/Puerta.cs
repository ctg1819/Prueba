using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Puerta
{
    class Puerta
    {


        protected int ancho; // Ancho en centimetros 
        protected int alto; // Alto en centimetros 
        protected int color; // Color en formato RGB 
        protected bool abierta; // Abierta o cerrada 


        // Apartado 6.6 Constructores
        public Puerta() {
            ancho = 100;
            alto = 200;
            color = 0xFFFFFF;
            abierta = false;
        }

        public Puerta(int an, int al)
        {
            ancho = an;
            alto = al;
            color = 0xFFFFFF;
            abierta = false;
        }


        public void Abrir()
        {
            abierta = true;
        }
        public void Cerrar()
        {
            abierta = false;
        }
        public void MostrarEstado()
        {
            Console.WriteLine("Ancho: {0}", ancho);
            Console.WriteLine("Alto: {0}", alto);
            Console.WriteLine("Color: {0}", color);
            Console.WriteLine("Abierta: {0}", abierta);
        }
        public int GetAncho()
        {
            return ancho;
        }
        public void SetAncho(int nuevoValor)
        {
            ancho = nuevoValor;
        }





    }
}
