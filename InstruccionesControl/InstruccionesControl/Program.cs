using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstruccionesControl
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("INSTRUCCIONES DE CONTROL");

			Console.WriteLine("If-else");
			int i = 0;
		
			// if sin llaves
			if (i == 0)
				Console.WriteLine("i es 0");

			int j = 1;
			// if else
			if (j == 0)
			{
				Console.WriteLine("j es 0");
			}
			else if(j < 0)
			{
				Console.WriteLine("j es menor que 0");
			} 
			else
			{
				Console.WriteLine("j es mayor que 0");
			}
			// switch
			Console.WriteLine("\nSwitch");
			char c = 'c';
			switch(c)
			{
				case 'a':
					Console.WriteLine("El valor de c es a");
					break;
				case 'b':
					Console.WriteLine("El valor de c es b");
					break;
				case 'c':
					Console.WriteLine("El valor de c es c");
					break;
				default:
					Console.WriteLine("Valor desconocido");
					break;
			}

			// while
			Console.WriteLine("\nWhile 1");
			int k = 1;
			while (k < 6)
			{
				Console.WriteLine("El valor de de k es {0}", k);
				k++;
			}

			// while que no se ejecuta nunca
			Console.WriteLine("While 2");
			int l = 7;
			while (l < 6)
			{
				Console.WriteLine("El valor de de l es {0}", l);
				l++;
			}

			// do while
			Console.WriteLine("Do-while 1");
			int m = 1;
			do
			{
				Console.WriteLine("El valor de de m es {0}", m);
				m++;
			} while (m < 6);

			// do while
			Console.WriteLine("Do-while 2");
			int n = 7;
			do 
			{
				Console.WriteLine("El valor de de n es {0}", n);
				n++;
			} while (n < 6) ;

			// for
			Console.WriteLine("\nFor");
			for (int o = 5; o > 0; o--)
			{
				Console.WriteLine(o);
			}

			// for con inicializador e iterador opcional
			Console.WriteLine("\nFor inicializador e iterador opcional");
			int r = 2;
			for (; r < 5; )
			{
				Console.WriteLine(r);
				r += 2;
			}

			// foreach
			Console.WriteLine("\nForeach");
			string s = "Hola mundo";
			foreach (char ch in s)
			{
				Console.WriteLine(ch);
			}

			// for equivalente al foreach
			Console.WriteLine("\nFor equivalente a foreach");
			for (int p=0; p < s.Length; p++)
			{
				Console.WriteLine(s[p]);
			}

			// break
			Console.WriteLine("\nBreak");
			int t = 1;
			while (t < 6)
			{
				if(t == 2)
				{
					break;
				}
				Console.WriteLine("El valor de de t es {0}", t);
				t++;
			}

			// continue
			Console.WriteLine("\nContinue");
			for(int u = 0; u < 5; u++) 
			{
				if (u == 2)
				{
					continue;
				}
				Console.WriteLine("El valor de de u es {0}", u);
			}

			// goto
			Console.WriteLine("\nGoto");
			Console.WriteLine("Imprimo 1");
			goto aqui;
			Console.WriteLine("Imprimo 2");
			Console.WriteLine("Imprimo 3");
			aqui:
				Console.WriteLine("Imprimo 4");
				Console.WriteLine("Imprimo 5");

			Console.ReadKey();
		}
	}
}
