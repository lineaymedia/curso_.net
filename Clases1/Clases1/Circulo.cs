using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases1
{
	class Circulo
	{
		// atributos de la clase
		const double PI = 3.151592; // las constantes siempre se tienen que inicializar en la declaracion
		// const double PI_2; 
		public double radio;
		public double area;

		// metodos de la clase
		public void AsignarRadio(double radio)
		{
			this.radio = radio;		// el atributo radio tiene el mismo nombre que el parámetro, asi que se usa this para acceder a el
		}

		public void CalcularArea()
		{
			area = PI * radio * radio;
		}

		public double ObtenerArea()
		{
			return area;
		}

		public void ImprimirArea()
		{
			Console.WriteLine("El area del circulo con radio {0} es {1}", radio, area);
		}
	}
}
