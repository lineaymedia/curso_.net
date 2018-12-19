using System;

namespace Interfaces
{
	// Rectangulo tiene que implementar todos los métodos de IImprimible
	public class Rectangulo : IImprimible
	{
		int ancho;
		int alto;

		public Rectangulo(int lado1, int lado2)
		{
			ancho = lado1;
			alto = lado2;
		}

		// Si Imprimir no se implementa, tendremos un error
		public void Imprimir()
		{
			Console.WriteLine("Ancho={0}, alto={1}", ancho, alto);
		}
	}
}
