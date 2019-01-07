using System;
namespace transporte
{
    // Creando la clase Barco
    public class Barco : Vehiculo
    {
        private int numHelices;
        private int eslora;

        public int NumHelices { get => numHelices; set => numHelices = value; }
        public int Eslora { get => eslora; set => eslora = value; }
    }
}
