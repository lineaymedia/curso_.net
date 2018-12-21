using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("ARRAYS");

			// Declaracion e inicializacion de array simple
			Console.WriteLine("\nArray simple");
			int[] array;
			array = new int[10]; // equivalente a int[] array = new int[10];

			int[] array1 = new int[3] { 1, 2, 3 };
			int[] array2 = new int[] { 1, 2, 3 };	// al inicializarlo se puede omitir el tamaño
			int[] array3 = { 1, 2, 3 };          // al inicializarlo tambien se puede omitir el new
			//int[] arrayInvalido = new int[];		// error al no indicar tamaño ni inicializarlo

			const int arraySize = 3;    // tamaño del array debe ser constante. Sin const no compila.
			int[] arrayCuatro = new int[arraySize] { 1, 2, 3 };

			// Acceso array simple
			int[] arrayAcceso1 = new int[10];
			arrayAcceso1[0] = 1;          // almacenar 1 en el primer elemento del array
			int valor = arrayAcceso1[0];  // consultar el primer elemento del array
			Console.WriteLine("El primer elemento del array es: " + valor);

			// Metodos de la clase Array
			Console.WriteLine("Metodos de array. Dado el array [1, 2, 3]");
			int longitud = array1.Length;
			Console.WriteLine("Length - Numero elementos array: " + longitud);
			Array.Reverse(array1);
			Console.WriteLine("Reverse - El primer elemento del array es: " + array1[0]);
			Array.Sort(array1);
			Console.WriteLine("Sort - El primer elemento del array es: " + array1[0]);

			// Declaracion e inicializacion array multidimensional
			Console.WriteLine("\nArray multidimensional");
			int[,] arrayDosDim1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };    // Array o matriz de 
																				// dos dimensiones
			int[,] arrayDosDim2 = new int[,] { { 11, 12, 13 }, { 14, 15, 16 } };
			int[,] arrayDosDim3 = { { 21, 22, 23 }, { 24, 25, 26 } };
			string[,,] arrayTresDim = new string[2, 1, 3];                      // Array o matriz de 
																				// tres dimensiones

			// Acceso array multidimensional
			int[,] arrayAcceso2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
			Console.WriteLine("El elemento [1,2] del array es: " + arrayAcceso2[1, 2]);
			arrayAcceso2[1, 2] = 11;
			Console.WriteLine("El nuevo elemento [1,2] del array es: " + arrayAcceso2[1, 2]);

			// Declaracion e inicializacion de array de arrays
			Console.WriteLine("\nArray de arrays");
			int[][] arrayDeArrays;
			arrayDeArrays = new int[3][];   // Al inicializarlo hay que indicar al menos el 
											// tamaño del primer array

			int[][] arrayNum = new int[][] { new int[] { 2, 3, 4 }, new int[] { 5, 6, 7, 8, 9 } };

			// Acceso array de arrays
			string[][] arrayAcceso3 = new string[][] { new string[] { "hola" },
				new string[] { "bye", "ciao" } };
			Console.WriteLine("El elemento [1][1] del array es: " + arrayAcceso3[1][1]);

			// Uso de foreach en arrays
			Console.WriteLine("\nForeach en array simple");
			string[] arrayDeStrings1 = { "gracias", "thanks", "grazie", "danke" };
			foreach (string cadena in arrayDeStrings1)
			{
				Console.WriteLine(cadena);
			}

			Console.WriteLine("\n\nForeach en array multiple");
			string[,] arrayDeStrings2 = new string[,] { { "hola", "hello", "ciao", "hallo" }, 
				{ "gracias", "thanks", "grazie", "danke" } };
			foreach (string cadena in arrayDeStrings2)
			{
				Console.WriteLine(cadena);
			}
			Console.WriteLine("\nFor en array multiple");
			for (int fila = 0; fila < arrayDeStrings2.GetLength(0); fila++)
			{
				for (int col = 0; col < arrayDeStrings2.GetLength(1); col++)
				{
					Console.WriteLine(arrayDeStrings2[fila, col]);
				}

			}

			Console.WriteLine("\n\nForeach en array de arrays");
			string[][] arrayDeStrings3 = new string[][] { new string[] { "hola" },
				new string[] { "bye", "ciao" } };
			foreach (string[] subarray in arrayDeStrings3)
			{
				foreach (string cadena in subarray)
				{
					Console.WriteLine(cadena);
				}
			}
			Console.WriteLine("\nFor en array de arrays");
			for (int fila = 0; fila < arrayDeStrings3.Length; fila++)
			{
				for (int col = 0; col < arrayDeStrings3[fila].Length; col++)
				{
					Console.WriteLine(arrayDeStrings3[fila][col]);
				}
			}

			Console.ReadKey();
		}
	}
}
