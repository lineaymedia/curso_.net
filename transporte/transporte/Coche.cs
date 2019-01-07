using System;
namespace transporte
{
    // Creando la clase Coche
    public class Coche : Vehiculo
    {
        private int cilindrada;

        public int Cilindrada { get => cilindrada; set => cilindrada = value; }
    }
}
