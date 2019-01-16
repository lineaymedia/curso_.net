using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticandoInterfaces
{
    public class Rectangulo : ICalcularArea
    {
        private double lado;
        private double altura;

        public double Altura { get => altura; set => altura = value; }
        public double Lado { get => lado; set => lado = value; }

        public  Rectangulo (double Altura, double Lado) {
           this.Altura = altura;
           this.Lado = lado;
        }
        public double AreaRectangulo()
        {
            double area = Altura * Lado;
            return area;
        }

        public void AreaCuadrado(double lado)
        {
            
        }

        public void AreaRectangulo(double altura, double lado)
        {
            
        }

        public void Imprimir()
        {
            
        }
    }
}
