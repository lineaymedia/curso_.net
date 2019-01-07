using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleVehiculos;

namespace ConsoleVehiculos
{
        class Program
        {
            static void Main(string[] args)
            {

             Console.WriteLine("EJERCICIO NAVIDAD");

            //Llamada a metodo estatico 
            int resultado= Coche.SumarMatricula(8868);
            Console.WriteLine("\n Resultado de operación estatica: {1}");

             //Instanciar barco coche patinete
                Console. WriteLine("\nInstanciar Barco");
                
                Barco barco= new Barco((int)Vehiculo.Color.Rojo, 8, 558452541);

                Console.WriteLine("\nInstanciar Coche");
            //Coche coche = new Coche((int)Vehiculo.Color.Azul, 130, 558452542);

            Coche coche = new Coche((int)Vehiculo.Color.Azul, 130, 558452542);
            Console.WriteLine("\nInstanciar Patinete");
                 Patinete patinete = new Patinete((int)Vehiculo.Color.Verde, 22444455);

            Coche coche1 = new Coche((int)Vehiculo.Color.Rojo, 85, 558458547);
            Coche coche2 = new Coche((int)Vehiculo.Color.Verde, 115, 444452542);

           // int[] arrayCoches = new string[2] { Coche coche1, Coche coche2 };

            Coche[] coches = { coche1, coche2 };
            foreach (Coche c in coches)
            {
                Console.WriteLine(coche);
            }

            Vehiculo[] vehiculos = { barco, coche, patinete};
            foreach (Vehiculo v in vehiculos)
            {
                Console.WriteLine(v.Imprimir((int)Vehiculo.Descripcion, Coche.matricula, Coche.marca, Patinete.ruedas));
            }

            Console.ReadKey();



            
            }
        }
    }













