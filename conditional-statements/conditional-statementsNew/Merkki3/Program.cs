using System;

namespace Merkki3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Ohjelma laskee L kirjainten lukumäärän, syötä lause:");
			string Userinput = Console.ReadLine().ToUpper();

			int i = 0;
			foreach (char x in Userinput)
			{
				if (x == 'L')
					i++;
			}
			Console.WriteLine($"L kirjaimia on yhteensä: {i} ");
			Console.ReadKey();
		}
	}
}