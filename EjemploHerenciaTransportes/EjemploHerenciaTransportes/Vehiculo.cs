using System;

namespace EjemploHerenciaTransportes
{
	enum Color
	{
		Rojo,
		Verde, 
		Azul
	}
	abstract class Vehiculo
	{
		private Color color;
		private int numSerie;

		public Color Color { get => color; set => color = value; }
		public int NumSerie { get => numSerie; set => numSerie = value; }

		public Vehiculo(Color color, int numSerie)
		{
			this.Color = color;
			this.numSerie = numSerie;
		}

		public void Pinta(Color nuevoColor)
		{
			Color = nuevoColor;
		}

		public virtual string Imprimir()
		{
			return "El vehiculo es de color " + Color + " y su numero de serie es " + numSerie;
		}

		public static void ImprimirStatic()
		{
			Console.WriteLine("Soy un metodo estatico y no necesito objeto para ejecutarme");
		}

		public abstract string Conduccion();
	}
}
