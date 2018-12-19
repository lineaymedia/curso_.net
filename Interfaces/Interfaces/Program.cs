using System;

namespace Interfaces
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("HERENCIA EN INTERFACES");
			Documento documento = new Documento("Este es el contenido del primer documento");
			Rectangulo rectangulo = new Rectangulo(10, 20);
			// documento implementa todos los metodos de IImprimible e IArchivable
			documento.Escribir();
			documento.Leer();
			documento.Imprimir();
			documento.DestruirDocumento();

			// rectangulo implementa los metodos de IImprimible
			rectangulo.Imprimir();
			// rectangulo.Escribir();	// rectangulo no implementa los metodos de IArchivable

			// IArchivable archivable = new IArchivable(); // no se puede instanciar una interfaz

			Console.WriteLine("\nPOLIMORFISMO");
			IArchivable documento2 = new Documento("Este es el contenido del segundo documento");
			documento2.Escribir();
			documento2.Leer();
			//documento2.DestruirDocumento();	// documento2 solo puede acceder a los metodos de 
												// la interface que implementa


			Console.ReadKey();
		}
	}
}
