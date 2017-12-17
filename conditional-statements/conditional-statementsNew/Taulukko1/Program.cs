using System;

namespace Taulukko1
{
    class Program
    {
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Ohjelma arpoo 100 lukua 0-50 väliltä ja valmistaa niistä taulukon");
			Random rnd = new Random();
			int[] iT;
			iT = new int[100];
			double sum = 0;

			for (int i = 0; i < iT.Length; i++)
			{
				iT[i] = rnd.Next(0, 50);
				Console.WriteLine($"{iT[i]}");
			}

			for (int i = 0; i < iT.Length; i++)
			{
				sum += iT[i];
			}
			double ka = sum / 100;
			Console.WriteLine($"Lukujen keskiarvo on {ka}");
			Console.ReadKey();
		}
	}
}