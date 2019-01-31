using System;

namespace Excepciones
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				//Program.FuncionNullReference();
				Program.FuncionDivideByZero();
				//Program.FuncionIndexOutOfRange();
			}
			catch (NullReferenceException e)
			{
				Console.WriteLine("Se captura la excepcion NullReferenceException con error: " + e.Message);
				Program.ImprimirExcepcion(e);
			}
			catch (DivideByZeroException e)
			{
				Console.WriteLine("Se captura la excepcion DivideByZeroException con error: " + e.Message);
				Program.ImprimirExcepcion(e);
			}

			catch (IndexOutOfRangeException e)
			{
				Console.WriteLine("Se captura la excepcion IndexOutOfRangeException con error: " + e.Message);
				Program.ImprimirExcepcion(e);
			}
			finally
			{
				// Este codigo se va a ejecutar siempre, se lance una excepcion o no
				Console.WriteLine("Finally");
			}

			Console.ReadKey();

		}

		public static void FuncionNullReference()
		{
			Console.WriteLine("FuncionNullReference lanza explicitamente una excepcion");
			throw new NullReferenceException("Algo has hecho mal");
			Console.WriteLine("Este codigo no se va a ejecutar nunca");
		}

		public static void FuncionDivideByZero()
		{
			Console.WriteLine("FuncionDivideByZero lanza una excepcion por una division entre 0");
			int i = 0;
			int j = 10;
			int k = j / i;
			Console.WriteLine("Este codigo no se va a ejecutar nunca");
		}

		public static void FuncionIndexOutOfRange()
		{
			Console.WriteLine("FuncionIndexOutOfRange lanza una excepcion por el acceso incorrecto a un array");

			int[] array = { 1, 2, 3 };
			int i = array[array.Length];
			Console.WriteLine("Este codigo no se va a ejecutar nunca");
		}

		// Mas eficiente. Evita repetir codigo en cada catch
		public static void ImprimirExcepcion(Exception e)
		{
			Console.WriteLine("Se captura la excepcion " + e.GetType() + " con error: " + e.Message);
		}
	}
}
