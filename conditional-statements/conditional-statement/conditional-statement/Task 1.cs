﻿using System;

namespace conditional_statement
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Ohjelma tulostaa positiivinen, negatiivinen tai nolla.");
		    Console.Writeline("syötä luku: ");
			string userInput;
		    userInput = Console.ReadLine();

			int evaluatedNumber;
			int evaluatedNumber = int.TryParse(userInput, out evaluatedNumber);
			bool isNumber = int.TryParse(userInput, out evaluatedNumber);

			if(isNumber=true)
			if(evaluatedNumber < 0)
			{
			Console.WriteLine($"Numero {evaluatedNumber} on negatiivinen");	
			}
			else if {evaluatedNumber >0}
			{
				Console.WriteLine($"Numero {evaluatedNumber} on positiivinen");
			}
			else
			{
				Console.WriteLine($"Numero {evaluatedNumber} on nolla");
			}
			else
			{
				Console.WriteLine("Syötit muuta kuin numeroita!");
			}
			Console.WriteLine("Syötit arvon {0}",userInput);
			{
				Console.WriteLine($"Syötit arvon {userInput}");
			}
			Console.ReadKey();
		}

