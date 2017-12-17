using System;

namespace Merkki4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Ohjelma tarkastaa onko sana tai lause palindromi");
			string UserInput = Console.ReadLine().ToUpper();
			string reverseUserInput = "";

			for (int i = UserInput.Length - 1; i >= 0; i--)
			{
				reverseUserInput += UserInput[i];
			}
			if (UserInput.Replace(" ", "") == reverseUserInput.Replace(" ", ""))
			{
				Console.WriteLine($"Syöte {UserInput.ToLower()} on palindromi");
			}
			else
			{
				Console.WriteLine($"Syöte {UserInput.ToLower()} ei ole palindromi");
			}
			Console.ReadKey();
		}
	}
}