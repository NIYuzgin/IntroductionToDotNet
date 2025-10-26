using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите арифметическое выражение вида '2 + 3': ");
			string expression = Console.ReadLine();
			expression = expression.Replace('.', ',');

			char[] delimiters = new char[] { '+', '-', '*', '/' };
			string[] numbers = expression.Split(delimiters);

			Console.WriteLine(numbers[0]);
			Console.WriteLine(numbers[1]);
			Console.WriteLine(expression[expression.IndexOfAny(delimiters)]);
			
			double a = double.Parse(numbers[0]);
			double b = double.Parse(numbers[1]);
			switch (expression[expression.IndexOfAny(delimiters)])
			{
				case '+': Console.WriteLine($"{numbers[0]} + {numbers[1]} = {a + b}"); break;
				case '-': Console.WriteLine($"{numbers[0]} - {numbers[1]} = {a - b}"); break;
				case '*': Console.WriteLine($"{numbers[0]} * {numbers[1]} = {a * b}"); break;
				case '/': Console.WriteLine($"{numbers[0]} / {numbers[1]} = {a / b}"); break;

				default: Console.WriteLine("Error: No operation"); break;
			}
		}
	}
}
