using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
	public class Cilindro : Circulo
	{
		double altura;

		// se invoca el constructor con un parametro de la clase base
		public Cilindro(double radio, double altura) :base(radio)
		{
			this.altura = altura;
			Console.WriteLine("Se ejecuta el contructor de la clase Cilindro 2");
		}

		// se invoca al constructor de la propia clase
		public Cilindro(double altura) :this(10, altura)
		{
			Console.WriteLine("Se ejecuta el contructor de la clase Cilindro 1");
		}

		public override double Area()
		{
			Console.WriteLine("Calculando el area del cilindro");
			return PI * radio * radio * altura;
		}
		
		public void ImprimirCilindro()
		{
			Console.WriteLine("La altura del cilindro es: " + altura);
		}
	}
}
