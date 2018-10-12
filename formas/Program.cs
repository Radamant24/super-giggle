using System;
using System.Collections.Generic;

namespace formas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Forma> myList = new List<Forma>();
            myList.Add(new Cuadrado(4));
            myList.Add(new Triangulo(5,10));
            myList.Add(new Circulo(5));

            foreach (Forma item in myList)
            {
                Console.WriteLine(item.PrintArea());
            }
            
        }
    }
}
