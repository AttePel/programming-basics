using System;

namespace Taulukko1
{
    class Program
    {
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Ohjelma arpoo 100 lukua 0-50 väliltä ja valmistaa niistä taulukon");
			int[] arrayNumber = new int[100];
			Random rnd = new Random();
			double sum = 0; 
			for (int i = 0; i < arrayNumber.Length; i++)
			{
				arrayNumber[i] = rnd.Next(0, 51);
			}
			for (int i = 0; i < arrayNumber.Length; i++)
			{
				Console.WriteLine($"{i} {arrayNumber[i]}");
				sum += arrayNumber[i];
			}
			Console.WriteLine($"Lukujen summa on {sum}");
			Console.WriteLine($"Lukujen keskiarvo on {sum / arrayNumber.Length:f2}");
			Console.ReadKey();
		}
    }
}
