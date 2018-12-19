using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	interface IImprimible
	{
		void Imprimir();
		// private void Imprimir(); // los miembros de una interfaz son siempre publicos
									// para que puedan ser implementados
	}
}
