using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases1
{
	class Alumno
	{
		double nota;
		public static double notaIngenieros = 6;


		public void AsignarNota(double nota)
		{
			this.nota = nota;
		}
		public bool EstaAdmitido()
		{
			return (nota >= notaIngenieros);
		}
		public void ImprimirResultado(string nombre)
		{
			if (EstaAdmitido())
			{
				Console.WriteLine("El alumno {0} está admitido", nombre);
			}
			else
			{
				Console.WriteLine("El alumno {0} no está admitido", nombre);
			}
		}
	}
}
