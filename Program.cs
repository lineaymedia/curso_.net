using System;
using Test1;

namespace Test1_sumas
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Suma de numeros y pintar resultado 
            Console.WriteLine("Dime un numero para sumar");

            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime otro numero para sumar");

            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado es de la suma es " + (numero1 + numero2));

            //Multiplicaciones

            Console.WriteLine("Multiplicando por 35\n Inserta un numero");
            int multiplicacion35 = 35;

            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Multiplicando por 30\n Inserta un numero");
            int multiplicacion30 = 30;

            int valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado es " + (valor1 * multiplicacion30));
            Console.WriteLine("El resultado es " + (valor2 * multiplicacion35));

            // Ejemplo sobrecarga con llamada a otro namespace
            Console.WriteLine("\nSobrecarga");
            Sobrecarga.Imprimir("Ejemplo de sobrecarga");
            Sobrecarga.Imprimir(1);
            Sobrecarga.Imprimir("Ejemplo", "facil");

            Console.WriteLine("\nSobrecarga dos");
            int dividiendo = division(100, 10, 5);
            Console.WriteLine(dividiendo);
            int dividiendo2 = division(10, 2);
            Console.WriteLine(dividiendo);
            int dividiendo3 = division("Test sobrecarga", 3);
            Console.WriteLine(dividiendo);

            //int dividiendo = division(100, 10, 5);
            //Console.WriteLine(dividiendo);

            //Calculo del area

            Console.WriteLine("Calculo del area");
            const double PI = 3.1416;

            Console.WriteLine("Introduvir valor para calcular el area de un circulo");

            double radio = double.Parse(Console.ReadLine());

            double calculoRadio = Math.Pow(radio, 2)*PI;

            Console.WriteLine(calculoRadio);


            //Console.WriteLine("\n Test while");
            //int numero10 = 1;
            //while (numero10 < 10)
            //{
            //    Console.WriteLine("El numero10 es {0}", numero10);
            //    numero10++;
            //}

            //Console.WriteLine("\n Test while 2");
            //int d = 10;
            //while (d < 9)
            //{
            //    Console.WriteLine("El numero de es {0}", d);
            //    d++;
            //}


            sumandoAlgo(5, 6);


        }

        static void sumandoAlgo(int suma1, int suma2)

        {

        Console.WriteLine($"La suma de mis numeros es {suma1+suma2}");

        }

        public static int division(int a, int b)
        {
            return a / b;
        }

        public static int division(int a, int b, int c)
        {
            return a / b / c;
        }

        //public static int division(int a, int b, double c)
        //{
        //    return a / b / c;
        //}

        public static int division(string a ,int b)
        {
            return b;
        }
    }
}
