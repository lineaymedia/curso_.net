using System;

namespace transporte
{
    class MainClass
    {
        //enum Testcolores
        //{
        //    amarillito,
        //    rojito,
        //    azulito
        //}
        public static void Main(string[] args)
        {
            Console.WriteLine("Vamos a construir nuestros Vehiculos");

            // Constuctor de Coche
            Console.WriteLine("Creamos un coche");
            Coche coche1 = new Coche();
            Console.WriteLine("Indicanos tu numero de serie");
            coche1.NumSerie = int.Parse(Console.ReadLine());
            Console.WriteLine("Indicanos tu cilindrada");
            coche1.Cilindrada = int.Parse(Console.ReadLine());
            Console.WriteLine("Seleciona tu color: \n 1 - Rojo \n 2 - Verde \n 3 - Azul \n 4 - Amarillo ");
            coche1.Color = (Color)int.Parse(Console.ReadLine());

            //Console.WriteLine("\n El numero de serie es: {0} \n La cilindrada es: {1} \n El color es: {2} ", coche1.NumSerie, coche1.Cilindrada, coche1.Color);

            // Constructor de Barco
            Console.WriteLine("Creamos un Barco");
            Barco barco1 = new Barco();
            Console.WriteLine("Seleciona tu color: \n 1 - Rojo \n 2 - Verde \n 3 - Azul \n 4 - Amarillo ");
            barco1.Color = (Color)int.Parse(Console.ReadLine());
            Console.WriteLine("Indicanos tu numero de serie");
            barco1.NumSerie = int.Parse(Console.ReadLine());
            Console.WriteLine("Indicanos cuantas Helices tiene");
            barco1.NumHelices = int.Parse(Console.ReadLine());
            Console.WriteLine("Indicanos los metros de Eslora");
            barco1.Eslora = int.Parse(Console.ReadLine());

            //Console.WriteLine("\n El color es: {0} \n El numero de serie es: {1} \n Dispone de {2} Helices \n Tiene {3}m de Eslora", barco1.Color, barco1.NumSerie, barco1.NumHelices, barco1.Eslora);

            // Constructor Patinete
            Console.WriteLine("Creamos un Patinete");
            Patinete patinete1 = new Patinete();
            Console.WriteLine("Seleciona tu color: \n 1 - Rojo \n 2 - Verde \n 3 - Azul \n 4 - Amarillo ");
            patinete1.Color = (Color)int.Parse(Console.ReadLine());
            Console.WriteLine("Indicanos tu numero de serie");
            patinete1.NumSerie = int.Parse(Console.ReadLine());

            // Pintamos nuestrso vehiculos
            Console.WriteLine("Nuestro coche \n El numero de serie es: {0} \n La cilindrada es: {1} \n El color es: {2} ", coche1.NumSerie, coche1.Cilindrada, coche1.Color);
            Console.WriteLine("Nuestro Barco \n El color es: {0} \n El numero de serie es: {1} \n Dispone de {2} Helices \n Tiene {3}m de Eslora", barco1.Color, barco1.NumSerie, barco1.NumHelices, barco1.Eslora);
            Console.WriteLine("Nuestro Patinete \n El color es: {0} \n El numero de serie es: {1}", patinete1.Color, patinete1.NumSerie);



            //Console.WriteLine("El color es {0}", coche1.Color);

            //Vehiculo vehiculo1 = new Vehiculo();

            //Console.WriteLine("Numero de serie: ");
            //vehiculo1.NumSerie = int.Parse(Console.ReadLine());

            //Console.WriteLine("El numeor de serie es: {0}", vehiculo1.NumSerie);

            //Coche coche1 = new Coche();
            //coche1.NumSerie = int.Parse(Console.ReadLine());
            //coche1.Cilindrada = int.Parse(Console.ReadLine());
            //coche1.Color = (Color)int.Parse(Console.ReadLine());

            //Console.WriteLine("El numero de serie es: {0} La cilindrada es {1}", coche1.NumSerie, coche1.Cilindrada);
            //Console.WriteLine("El color es {0}", coche1.Color);


            //coche1.Color = Color;
            //Testcolores testcolores = (Testcolores)Convert.ToInt32(Console.ReadLine());
            //Testcolores testcolores = (Testcolores)int.Parse(Console.ReadLine());
            //switch (testcolores)
            //{
            //    case Testcolores.amarillito:
            //        Console.Write("Amarillito");
            //        break;
            //    case Testcolores.azulito:
            //        Console.WriteLine("Azulito");
            //        break;
            //    case Testcolores.rojito:
            //        Console.WriteLine("Rojito");
            //        break;
            //    default:
            //        Console.WriteLine("sin color");
            //        break;
            //}

        }

    }
}
