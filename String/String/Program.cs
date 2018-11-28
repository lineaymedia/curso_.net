using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("STRING");
			
			string cadena1 = "Hola";
			string cadena2 = " mundo";
			// Concatenacion de strings
			string cadena3 = cadena1 + cadena2;     
			Console.WriteLine(cadena3);

			// Longitud de la cadena
			Console.WriteLine("Tiene una longitud de " + cadena3.Length);

			// Acceso a caracteres del string
			char primerCaracter = cadena3[0];
			Console.WriteLine("Primer caracter: " + primerCaracter);

			// Posicion de un caracter en el string
			int posicionO = cadena3.IndexOf('o');
			int posicionZ = cadena3.IndexOf('z');
			Console.WriteLine("Posicion letra o: " + posicionO);	// Posicion de la primera ocurrencia de 'o' en el string
			Console.WriteLine("Posicion letra z: " + posicionZ);	// -1 ya que el string no contiene 'z'

			// Comparacion de strings
			string s1 = "Hola";
			string s2 = "Hola";
			Console.WriteLine("Las cadenas {0} y {1} tienen el mismo valor: " + (s1 == s2), s1, s2);

			// Contenido de un string constante, no se puede cambiar
			string unaFrase = "Esto es una frase";
			unaFrase.Replace('o', 'a');
			Console.WriteLine(unaFrase);
			string nuevaFrase = unaFrase.Replace('o', 'a');		// Hay que asignar el resultado del replace a un nuevo string
			Console.WriteLine(nuevaFrase);

			Console.ReadKey();
		}
	}
}
