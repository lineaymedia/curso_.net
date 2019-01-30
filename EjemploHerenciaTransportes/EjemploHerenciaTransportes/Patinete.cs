
namespace EjemploHerenciaTransportes
{
	class Patinete : Vehiculo
	{
		public Patinete(Color color, int numSerie) : base(color, numSerie)
		{
		}

		public override string Imprimir()
		{
			return "El patinete es de color " + Color + " y su numero de serie es " + NumSerie;
		}

		public override string Conduccion()
		{
			return "El patinete de conduce con manillar";
		}
	}
}
