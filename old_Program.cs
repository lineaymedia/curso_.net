using System;

namespace clima_peligroso
{
    class Clima
    {
        static void Main()
        {
            // Call method with embedded if-statement three times.
            int madrid = Temperatura(0);
            int santander = Temperatura(8);
            int logroño = Temperatura(-1);
            int cadiz = Temperatura(19);

            // Print results.
            Console.WriteLine("En Madrid hace " + madrid);
            Console.WriteLine("En Santandder hace " + santander);
            Console.WriteLine("En Logroño hace " + logroño);
            Console.WriteLine("En Cadiz hace " + cadiz);
        }

        static int Temperatura(int value)
        {
            if (value == 0)
            {
                return 12;
            }
            else if (value <= 10)
            {
                return 15;
            }
            else if (value <= 20)
            {
                return 18;
            }
            else if (value <= 30)
            {
                return 20;
            }
            else
            {
                return 25;
            }
        }
    }
}
