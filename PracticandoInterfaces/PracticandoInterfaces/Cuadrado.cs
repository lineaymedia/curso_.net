using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticandoInterfaces
{
  public  class Cuadrado : ICalcularArea 
    {
        private double lado;
        

        public double Lado { get => lado; set => lado = value; }

        public Cuadrado(double lado)
        {
            this.Lado = lado;          
        }

             


        public double AreaCuadrado()
        {
            double area = lado * lado;
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
