using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string cita = "Muchos años después, frente al pelotón de fusilamiento, el coronel Aureliano Buendía había de recordar aquella tarde remota en que su padre lo llevó a conocer el hielo. Macondo era entonces una aldea de 20 casas de barro y cañabrava construidas a la orilla de un río de aguas diáfanas que se precipitaban por un lecho de piedras pulidas, blancas y enormes como huevos prehistóricos. El mundo era tan reciente, que muchas cosas carecían de nombre, y para mencionarlas había que señalarlas con el dedo";
            string cita2;
            string cita3;
            string cita4;
            string cita5;
            string cita6;
            string cita7;
            string cita8;
            string cita9;
            string cita10;
            string cita11;
            Console.WriteLine(cita);
            cita = cita.ToLower();
            cita2 = cita.Replace("a", "$");
            cita3 = cita2.Replace("e", "$");
            cita4 = cita3.Replace("i", "$");
            cita5 = cita4.Replace("o", "$");
            cita6 = cita5.Replace("u", "$");
            cita7 = cita6.Replace("á", "$");
            cita8 = cita7.Replace("é", "$");
            cita9 = cita8.Replace("í", "$");
            cita10 = cita9.Replace("ó", "$");
            cita11 = cita10.Replace("ú", "$");
            Console.WriteLine(cita11.Replace("$",""));
            Console.ReadKey();
        }
    }
}
