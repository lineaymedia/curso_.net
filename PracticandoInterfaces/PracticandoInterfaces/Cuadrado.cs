using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticandoInterfaces
{
  public class Cuadrado : ICalcArea 
    {
        private double lado;
        

        public double Lado { get => lado; set => lado = value; }

        public Cuadrado(double lado)
        {
            Lado = lado;          
        }

             


        public double Area()
        {
            return lado * lado;
            
        }
       

        public void Imprimir()
        {
            Console.WriteLine("el area del cuadrado es: " + Area()); 
        }
    }
}
