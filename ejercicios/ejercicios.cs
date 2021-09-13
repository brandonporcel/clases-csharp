using System;
using System.Collections.Generic;
namespace ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Int16> listNumeros = new List<Int16>();


            listNumeros.Add(20);
            listNumeros.Add(2);
            listNumeros.Add(30);
            listNumeros.Add(10);
            listNumeros.Add(5);

            int posDiez = listNumeros.IndexOf(10);
            listNumeros.Insert(posDiez + 1, 0);
            listNumeros.Insert(posDiez - 1, 0);
            //4
            listNumeros.RemoveAt(0);
            listNumeros.RemoveAt(listNumeros.Count - 1);
            //5
            listNumeros.RemoveAt(1);
            listNumeros.RemoveAt(listNumeros.Count - 2);
            Console.ReadKey();

        }
    }
}
