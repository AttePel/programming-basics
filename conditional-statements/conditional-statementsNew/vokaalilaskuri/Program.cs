using System;

namespace vokaalilaskuri
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.Write("Ohjelma laskee vokaalit. Syötä sana tai lause: ");
			string userInput;
			userInput = Console.ReadLine().ToUpper();
			int maara = 0;
			string vokaalit = "AEIOUYÄÖ";


			for (int i = 0; i < userInput.Length; i++)
			{
				for (int j = 0; j < vokaalit.Length; j++)
				{
					if (vokaalit[j] == userInput[i])
					{
						maara++;
						break;
					}
				}
			}


			Console.WriteLine($"Syöttämässä tekstissäsi on {maara} vokaalia.");
			Console.ReadKey();
		}
	}
}