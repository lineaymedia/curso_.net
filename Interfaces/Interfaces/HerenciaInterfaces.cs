using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	// implementa los métodos de IHija y de IPadre
	class HerenciaInterfaces : IHija
	{
		public void ImprimirHija()
		{
			Console.WriteLine("Implemento una clase de IHija");
		}

		public void ImprimirPadre()
		{
			Console.WriteLine("Implemento una clase de IPadre");
		}
	}
}
