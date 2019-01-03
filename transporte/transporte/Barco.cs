using System;
namespace transporte
{
    // Creando la clase Barco
    public class Barco
    {
        private int numHelices;
        private int eslora;

        public int NumHelices
        {
            get
            {
                return this.numHelices;
            }
            set
            {
                this.numHelices = value;
            }
        }

        public int Eslora
        {
            get
            {
                return this.eslora;
            }
            set
            {
                this.eslora = value;
            }
        }
    }
}
