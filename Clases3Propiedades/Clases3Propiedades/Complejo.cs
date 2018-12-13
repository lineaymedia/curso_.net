
namespace Clases3Propiedades
{
	class Complejo
	{
		private int numero1;
		// Propiedad automática
		public int Numero2 { get; set; }

		// Se podria poner como propiedad automática
		private int numero3;

		// Una manera de definir la propiedad
		public int Numero1
		{
			get
			{
				return numero1;
			}
			set
			{
				if (value > 0)
				{
					numero1 = value;
				} else
				{
					numero1 = 0;
				}
			}
		}

		// Otra manera de definir la propiedad. Se podria usar una propiedad automática.
		public int Numero3 { get => numero3; set => numero3 = value; }
	}
}
