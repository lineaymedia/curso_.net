using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticandoInterfaces
{
   public interface ICalcularArea
    {
       void AreaCuadrado(double lado);
       void AreaRectangulo(double altura, double lado);
       void Imprimir();
    }
}
