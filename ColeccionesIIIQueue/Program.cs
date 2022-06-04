using System;
using System.Collections.Generic;

namespace ColeccionesIIIQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numeros = new Queue<int>();

            foreach(int numero in new int[5] {10, 2, 4, 6, 8})
            {//agrega a la cola o encola los numeros del array
                numeros.Enqueue(numero);
            }
            Console.WriteLine("Recorrer el queue");
            foreach (int numero in numeros )
            {
                Console.WriteLine(numero);
            }
            //eliminando elementos del queue
            Console.WriteLine("eliminando elementos");
            numeros.Dequeue();
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
