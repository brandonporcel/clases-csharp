using System;
using System.Collections.Generic;

namespace copitoss
{
    class Program
    {
        static List<Copo> listaCopos = new List<Copo>();
        static void Main(string[] args)
        {
            //Creo variable de tipo timespan para guardar el tiempo transcurrido desde la creacion del ultimo copo.
            TimeSpan diferencia;
            //Creo dos objetos DateTime para guardar en uno el momento en en el que se creo el ultimo copo y en el otro el tiempo actual del programa. 
            DateTime inicio, actual;
            //Creo un objeto de tipo tecla para guardar cualquier tecla que se presione mientras el programa esta corriendo para poder luego realizar acciones con ella. 
            ConsoleKeyInfo tecla;
            //Inicializo el objeto de inicio con el tiempo actual. 
            inicio = DateTime.Now;
            //Guardo en forma de una constante el ancho que va a tener la pantalla.
            const int ancho = 80;
            //Guardo en forma de una constante el alto que va a tener la pantalla.              
            const int alto = 25;
            //Creo e inicializo la variable de velocidad. Esta marcara el ritmo con el que se creen los copos. 
            int velocidad = 500;
            //Creo un objeto de tipo random para poder generar numeros random al momento de decidir en que posicion crear el nuevo copo.
            Random numRandom = new Random();
            Copo c = null;


            //Loop infinito para ejecutar el programa principal.

            /*c = new Copo(numRandom.Next(0, 79), numRandom.Next(0, 24));
            listaCopos.Add(c);
            c = new Copo(numRandom.Next(0, 79), numRandom.Next(0, 24));
            listaCopos.Add(c);
            c = new Copo(numRandom.Next(0, 79), numRandom.Next(0, 24));
            listaCopos.Add(c);
            */
            inicio = DateTime.Now;

            while (true)
            {
                //En caso de que alguna tecla se presionada:
                if (Console.KeyAvailable)
                {
                    tecla = Console.ReadKey();

                    switch (tecla.Key)
                    {
                        case ConsoleKey.Enter:
                            //c = new Copo(numRandom.Next(0, 79), 0);
                            //listaCopos.Add(c);
                            break;
                    }
                }


                //Guardo la la fecha actual en el objeto Datetime "actual".
                actual = DateTime.Now;
                //Calculo la diferencia de tiempo transcurrido entre inicio y acutal.
                diferencia = actual - inicio;
                //Si la diferencia de tiempo es mayor al tiempo que debe transcurrir para que se cree un nuevo copo, entonces creo un copo, bajo el resto si es posible, y si la ultima fila se encuentra llena, la elimino. 
                if (diferencia.Milliseconds > velocidad)
                {
                    c = new Copo(numRandom.Next(0, 79), 0);
                    listaCopos.Add(c);

                    //Genero un numero random que definira en que columna se creara el nuevo copo.
                    foreach (Copo copo in listaCopos)
                    {
                        copo.bajar();
                        copo.dibujar();
                    }

                    //Actualizo el objeto DateTime "inicio" para que lleve la fecha y hora a la que se termino de dibujar el ultimo copo y asi poder saber luego cuando ya paso el tiempo requerido para crear un nuevo copo. 
                    inicio = DateTime.Now;
                }
            }

            /*
            //En caso de que alguna tecla se presionada:
            if (Console.KeyAvailable)
            {
                //Guardo temporalmente la tecla en el objeto tecla.
                tecla = Console.ReadKey();
                switch (tecla.Key)
                {
                    break;
                }
            }
            */
            /*
            //Guardo la la fecha actual en el objeto Datetime "actual".
            actual = DateTime.Now;
            //Calculo la diferencia de tiempo transcurrido entre inicio y acutal.
            diferencia = actual - inicio;
            //Si la diferencia de tiempo es mayor al tiempo que debe transcurrir para que se cree un nuevo copo, entonces creo un copo, bajo el resto si es posible, y si la ultima fila se encuentra llena, la elimino. 
            if (diferencia.Milliseconds > velocidad)
            {
                //Genero un numero random que definira en que columna se creara el nuevo copo.
                int temp_col = numRandom.Next(0, ancho);

                //Actualizo el objeto DateTime "inicio" para que lleve la fecha y hora a la que se termino de dibujar el ultimo copo y asi poder saber luego cuando ya paso el tiempo requerido para crear un nuevo copo. 
                inicio = DateTime.Now;
            }
            */

        }
    }
}