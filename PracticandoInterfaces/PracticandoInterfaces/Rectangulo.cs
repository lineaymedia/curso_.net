using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticandoInterfaces
{
    public class Rectangulo : ICalcArea
    {
        private double lado;
        private double altura;

        public double Altura    { get => altura; set => altura = value; }
        public double Lado      { get => lado; set => lado = value; }

        public Rectangulo (double altura, double lado)
        {
           Altura   = altura;
           Lado     = lado;
        }

        public double Area()
        {
            return altura * lado;            
        }

      

        public void Imprimir()
        {
            Console.WriteLine("el area del rectángulo es: " + Area());
        }
    }
}
