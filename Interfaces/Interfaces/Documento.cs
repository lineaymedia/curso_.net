using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	// Rectangulo tiene que implementar todos los métodos de IImprimible y de IArchivable
	class Documento : IImprimible, IArchivable
	{
		string contenido;

		public Documento(string frase)
		{
			contenido = frase;
		}

		public void Imprimir()
		{
			Console.WriteLine(contenido);
		}

		public void Leer()
		{
			Console.WriteLine("Leyendo contenido desde el disco duro");
		}

		public void Escribir()
		{
			Console.WriteLine("Escribiendo contenido en disco duro");
		}

		public void DestruirDocumento()
		{
			Console.WriteLine("El contenido del documento sera destruido");
		}
	}
}
