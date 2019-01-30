namespace EjemploHerenciaTransportes
{
	class Barco : Vehiculo
	{
		private int numHelices;
		private int eslora;

		public Barco(Color color, int numSerie, int numHelices, int eslora) : base(color, numSerie)
		{
			this.numHelices = numHelices;
			this.eslora = eslora;
		}

		public override string Imprimir()
		{
			//return "El coche es de color " + Color + ", su numero de serie es " + NumSerie + " y la cilindrada es " + cilindrada;
			return base.Imprimir() + ", tiene " + numHelices + " helice y su eslora es " + eslora;
		}

		public override string Conduccion()
		{
			return "El barco se maneja con timón";
		}
	}
}
