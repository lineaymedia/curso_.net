
using System;

namespace ListaNumerosPrimos

{

    class ListaNumerosPrimos

    {

        static void Main()

        {

            for (int i = 1; i <= 1000; i++)

            {

                if (i % 2 == 0 && i != 2 ) continue;
                if (i % 3 == 0 && i != 3 ) continue;
                if (i % 5 == 0 && i != 5 ) continue;
                if (i % 7 == 0 && i != 7 ) continue;              

                Console.WriteLine(i);
                

            }
            Console.ReadLine();




        }

    }

}

