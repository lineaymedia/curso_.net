using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobrecarga
{
    class Program
    {
        public int Sumar(int x1, int x2)
        {
            int s = x1 + x2;
            return s;
        }

        public string Sumar(string s1, string s2)
        {
            string s = s1 + s2;
            return s;
        }

        private int altura = 170;

        static void Main()
        {
            Program p = new Program();
            Console.WriteLine("1+2 es:" + p.Sumar(1, 2));
            Console.WriteLine("Concatenacion de nombre y apellido " + p.Sumar("Javier", " Prada"));
            Console.WriteLine("Altura es: " + p.altura);
            Console.ReadKey();
        }
    }
}