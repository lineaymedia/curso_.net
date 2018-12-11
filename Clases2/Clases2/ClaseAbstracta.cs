using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases2
{
	abstract class ClaseAbstracta
	{
		int x = 100;
		int y = 200;

		public abstract int GetX
		{
			get;	// El metodo get de la clase no se implementa
		}

		// y es una propiedad de lectura y escritura
		public int Y
		{
			get
			{
				return y;
			}
			set
			{
				y = value;
			}
		}
	}
}
