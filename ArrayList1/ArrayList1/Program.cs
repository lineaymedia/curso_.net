using System;

// para utilizar ArrayList hay que incluir esta libreria
using System.Collections;

namespace ArrayList1
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("ARRAYLIST");

			// Declaracion e inicializacion de un ArrayList;
			ArrayList lista = new ArrayList(6);
            lista.Add("Juan");
            lista.Add("Ana");
            lista.Add("Laura");
            String nombre = "Pedro";
            lista.Add(nombre);

			Console.Write("Metodos arraylist. Dado el arraylist: ");
			ImprimirLista(lista);
			Console.WriteLine("	Capacity - Capacidad del arraylist: " + lista.Capacity);
            Console.WriteLine("	Count - Elementos del arraylist: " + lista.Count);
            Console.WriteLine("	IndexOf - Posicion de 'Laura' en el arraylist: " + lista.IndexOf("Laura"));
            Console.WriteLine("	Contains - ¿Pertenece 'Diego' al arraylist? " + lista.Contains("Diego"));

			lista.Insert(1, "	Carmen");   
			Console.Write("	Insert - Insertar Carmen en la posicion 1 del arraylist: ");
			ImprimirLista(lista);

			ArrayList lista2 = new ArrayList();
			lista2.Add("Ramon");
			lista2.Add("Carlos");

			lista.AddRange(lista2);       // Añadir una coleccion de valores
			Console.Write("	AddRange - Añadir la lista [Ramon, Carlos] al arraylist: ");
			ImprimirLista(lista);

			lista.Remove("Pedro");    
			Console.Write("	Remove - Borrar Pedro del arraylist: ");
			ImprimirLista(lista);

			lista.RemoveAt(0);    
			Console.Write("	RemoveAt - Borrar la posicion 0 del arraylist: ");
			ImprimirLista(lista);

			lista.Sort();
			Console.Write("	Sort - Ordena los elementos del arraylist: ");
			ImprimirLista(lista);

			Console.WriteLine("\nSe borran todos los elementos del arraylist");
			lista.Clear();

			Console.WriteLine("Ahora el tamaño del arraylist es: " + lista.Count);

			Console.WriteLine("\nEjemplo de foreach con arraylist");
			foreach (String n in lista)
            {
                Console.WriteLine(n);
            }

            Console.ReadKey();
        }

		public static void ImprimirLista(ArrayList lista)
		{
			foreach (Object obj in lista)
				Console.Write(" {0}", obj);
			Console.WriteLine();
		}
	}
}
