using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaceCantante
{
	class Canario : ICantante
	{
		public string Cantar()
		{
			return "Pio pio";
		}
	}
}
