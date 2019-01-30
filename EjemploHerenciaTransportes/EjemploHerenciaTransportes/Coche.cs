namespace EjemploHerenciaTransportes
{
	class Coche : Vehiculo
	{
		private int cilindrada;

		public Coche(Color color, int numSerie, int cilindrada) : base(color, numSerie)
		{
			this.cilindrada = cilindrada;
		}

		public static Coche operator +(Coche c1, Coche c2)
		{
			// Crear un coche con color y numSeries igual al primer operando.
			// Se indica cilindrada 0 en el constructor porque se va a modificar con la suma de las 
			// cilindradas de los operandos.
			//return new Coche(c1.Color, c1.NumSerie, c1.cilindrada + c2.cilindrada);
			Coche resultado = new Coche(c1.Color, c1.NumSerie, 0);
			resultado.cilindrada = c1.cilindrada + c2.cilindrada;
			return resultado;
		}

		public override string Imprimir()
		{
			return base.Imprimir() + " y su cilindrada es " + cilindrada;
		}

		public override string Conduccion()
		{
			return "El coche se conduce con volante";
		}
	}
}
