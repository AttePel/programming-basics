
using System;

namespace lotto
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Loton oikea rivi on:");
			int[] arrayNumber = new int[40];
			Random rnd = new Random();
			int i = 0;
			while (i < 7)
			{
				int rndNumber = rnd.Next(0, 41);
				if (arrayNumber[rndNumber] == 0)
				{
					arrayNumber[rndNumber] = 1;
					i++;
				}

			}
			for (i = 0; i < arrayNumber.Length; i++)
			{
				if (arrayNumber[i] == 1)
				{
					Console.WriteLine($"{i}");
				}
			}
			while (true)
			{
				int rndNumber = rnd.Next(0, 41);
				if (arrayNumber[rndNumber] == 0)
				{
					arrayNumber[rndNumber] = 2;
					break;

				}
			}
			for (i = 0; i < arrayNumber.Length; i++)
			{
				if (arrayNumber[i] == 2)
				{
					Console.WriteLine($"Lisänumero:{i}");
				}
			}
			Console.Write($"Tuplausnumero:{rnd.Next(0, 41)}");
			Console.ReadKey();


		}
	}
}