using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerenciaAula
{
	class Laboratorio : Aula
	{
		private int numEquipos;

		// Sobrecarga de constructores. Con base accedemos al constructor de la clase padre con 3 parametros.
		public Laboratorio(string nombre, int m2, int numEquipos) : base(nombre, m2, true)
		{
			Nombre = nombre;
			M2 = m2;
			this.numEquipos = numEquipos;
		}

		// Sobrecarga de constructores.
		// Si no hubieramos implementado el constructor por defecto en la clase padre, este constructor fallaria.
		public Laboratorio(string nombre, int m2, bool aireAcond, int numEquipos)
		{
			Nombre = nombre;
			M2 = m2;
			AireAcond = aireAcond;
			this.numEquipos = numEquipos;
		}

		// Como todos los atributos son privados, para acceder a los de la clase padre hay que usar el get.
		public void ImprimirLaboratorio()
		{
			Console.WriteLine("El laboratoio con nombre " + Nombre + 
				" tiene un tamaño de " + M2 +
				" m2, aire acondicionado " + AireAcond + 
				" y tiene " + numEquipos + " equipos");
		}
	}
}
