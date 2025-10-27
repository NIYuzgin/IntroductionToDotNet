//#define CALC
//#define CALC_IF
//#define CALC_SWITCH

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
			


#if CALC
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
#endif
			


			Console.Write("Введите арифметическое выражение: ");
			string expression = "22+33-44/2+8*3";
			//string expression = Console.ReadLine();
			expression = expression.Replace('.', ',');
			expression = expression.Replace(" ", "");
			Console.WriteLine(expression);

			char[] operators = new char[] { '+', '-', '*', '/' };
			string[] operands = expression.Split(operators);
			double[] values = new double[operands.Length];
			
			for (int i = 0; i < operands.Length; i++) 
			{
				values[i] = Convert.ToDouble(operands[i]);
				Console.Write($"{values[i]}\t");
			}
			Console.WriteLine();

			char[] digits = "0123456789.".ToCharArray();
			
			/*
			 for (int i = 0; i < digits.Length ; i++) {

				Console.Write($"{ digits[i]}\t");
			
			}
			Console.WriteLine();
			*/

			string[]operations = expression.Split(digits);
			operations = operations.Where(o => o != "").ToArray();	// LINQ
			
			for (int i = 0;i < operations.Length; i++) {
				Console.Write($"{operations[i]}\t");
			}
			Console.WriteLine();
		







#if CALC_IF
			if (expression.Contains("+"))
				Console.WriteLine($"{values[0]}+{values[1]} = {values[0] + values[1]}");
			else if (expression.Contains("-"))
				Console.WriteLine($"{values[0]}-{values[1]} = {values[0] - values[1]}");
			else if (expression.Contains("*"))
				Console.WriteLine($"{values[0]}*{values[1]} = {values[0] * values[1]}");
			else if (expression.Contains("/"))
				Console.WriteLine($"{values[0]}/{values[1]} = {values[0] / values[1]}");
			else Console.WriteLine("Error: No operation");

#endif

#if CALC_SWITCH
			switch (expression[expression.IndexOfAny(operators)])
			{
				case '+': Console.WriteLine($"{values[0]} + {values[1]} = {values[0] + values[1]}"); break;
				case '-': Console.WriteLine($"{values[0]} - {values[1]} = {values[0] - values[1]}"); break;
				case '*': Console.WriteLine($"{values[0]} * {values[1]} = {values[0] * values[1]}"); break;
				case '/': Console.WriteLine($"{values[0]} / {values[1]} = {values[0] / values[1]}"); break;


					//default: Console.WriteLine("Error: No operation"); break;
			}

#endif




		}
	}
}
