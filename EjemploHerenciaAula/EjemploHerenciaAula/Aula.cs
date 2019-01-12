using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerenciaAula
{
	class Aula
	{
		private string nombre;
		private int m2;
		private bool aireAcond;

		// Constructor por defecto
		// Lo implementamos porque al sobrecargar el constructor, el constructor por defecto desaparece.
		public Aula()
		{

		}

		// Sobrecarga de constructor
		public Aula(string nombre, int m2, bool aireAcond)
		{
			this.nombre = nombre;
			this.m2 = m2;
			this.aireAcond = aireAcond;
		}

		// Get y set de los atributos privados de la clase
		public string Nombre { get => nombre; set => nombre = value; }
		public int M2
		{
			get => m2;
			// Quiero controlar que m2 nunca sea negativo
			set
			{
				if (value < 0)
				{
					m2 = 0;
				}
				else
				{
					m2 = value;
				}
			}
		}
		public bool AireAcond { get => aireAcond; set => aireAcond = value; }

		// Aunque los atributos son privados, desde la propia clase se puede acceder directamente a ellos.
		public void ImprimirAula()
		{
			Console.WriteLine("El aula con nombre " + nombre + 
				" tiene un tamaño de " + m2 +
				" m2 y aire acondicionado " + aireAcond);
		}
	}
}
