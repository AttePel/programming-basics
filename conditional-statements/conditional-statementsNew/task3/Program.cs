using System;

namespace Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Ohjelma kysyy numeroa ja tulostaa positiivinen, negatiivinen tai nolla, sekä onko luku parillinen vai pariton.");
			Console.Write("Syötä Luku:");
			string userInput;
			userInput = Console.ReadLine();

			int evaluatedNumber;
			bool isNumber = int.TryParse(userInput, out evaluatedNumber);
			string isEven = String.Empty;
			string isPositive;

			if (evaluatedNumber % 2 == 0)
			{
				isEven = "parillinen";
			}
			else
			{
				isEven = "pariton";
			}

			if (evaluatedNumber > 0)
			{
				isPositive = "positiivinen";
			}
			else if (evaluatedNumber < 0)
			{
				isPositive = "negatiivinen";
			}
			else
			{
				isPositive = "nolla";
			}

			Console.WriteLine($"Numero on {isEven} sekä {isPositive}");
			Console.ReadKey();

		}
	}
}