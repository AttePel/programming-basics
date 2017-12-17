using System;

namespace Merkki2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Ohjelma muuttaa e kirjaimet @ merkiksi");
			string e = Console.ReadLine();
			e = e.Replace('e', '@');
			Console.WriteLine($"Output: {e} ");
			Console.ReadKey();
		}
	}
}