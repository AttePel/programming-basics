
using System;

namespace Merkki1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Ohjelma ilmoittaa merkkien lukumäärän");
			string merkkijono = Console.ReadLine();
			int length = merkkijono.Length;
			Console.WriteLine($"Merkkejä on yhteensä: {length} ");
			Console.ReadKey();

		}
	}
}