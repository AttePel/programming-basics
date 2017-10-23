using System;

namespace Task6
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;

			bool isNumber;
			int N = 1;
			int input;

			do
			{
				Console.Write("Syötä luku: ");

				if (isNumber = int.TryParse(Console.ReadLine(), out input)) ;
				{
					if (input > 0)
					{
						for (int i = 1; i <= input; i++)
						{
							N = N * i;
						}

						Console.WriteLine($"{N}");
						Console.ReadKey();
					}
				}

			}
			while (!isNumber || input < 0);
		}
	}
}