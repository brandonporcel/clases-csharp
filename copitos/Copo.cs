using System;
using System.Collections.Generic;
using System.Text;

namespace copitoss
{
    //Creo la clase copos. 
    class Copo
    {
        //Guardo como atributos de instancia la posicion donde este se encuentre en la pantalla.
        public int fila = 0, columna = 0;
        public Copo(int columna, int fila)
        {
            this.fila = fila;
            this.columna = columna;
        }
        //Funcion dibujar: Dibuja el copo en la pantalla escribiendo un * en la consola en la posicion donde este se encuentre. 
        public void dibujar()
        {
            Console.SetCursorPosition(this.columna, this.fila);
            Console.WriteLine("*");
        }
        //Funcion Bajar: Cambiar la variable fila en un valor mas. 
        public void bajar()
        {
            if (this.fila < 24)
            {
                Console.SetCursorPosition(this.columna, this.fila);
                Console.WriteLine(" ");
                this.fila = this.fila + 1;
            }
            //this.fila++;
        }
    }
}