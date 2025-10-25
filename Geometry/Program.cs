//#define GEOMETRY
#define HARD_CHESS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry {
	internal class Program {
		static void Main(string[] args) {

#if GEOMETRY
			Console.Write("Введите размер фигуры: ");
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();

			Console.WriteLine("1)");
			Console.WriteLine();
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			Console.WriteLine("2)");
			Console.WriteLine();
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j <= i; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			Console.WriteLine("3)");
			Console.WriteLine();
			for (int i = 0; i < n; i++)
			{
				for (int j = i; j < n; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			Console.WriteLine("4)");
			Console.WriteLine();
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < i; j++)
				{
					Console.Write("  ");
				}
				for (int j = i; j < n; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			Console.WriteLine("5)");
			Console.WriteLine();
			for (int i = 0; i < n; i++)
			{
				for (int j = i; j < n - 1; j++)
				{
					Console.Write("  ");
				}
				for (int j = n - i - 1; j < n; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			Console.WriteLine("6)");
			Console.WriteLine();
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n - i; j++)
				{
					Console.Write(" ");
				}
				Console.Write("/");

				for (int j = 0; j < 2 * i; j++)
				{
					Console.Write(" ");
				}
				Console.Write("\\");
				Console.WriteLine();
			}
			for (int i = n; i > 0; i--)
			{
				for (int j = 0; j < n - i; j++)
				{
					Console.Write(" ");
				}
				Console.Write(" \\");

				for (int j = 0; j < 2 * (i - 1); j++)
				{
					Console.Write(" ");
				}
				Console.Write("/");
				Console.WriteLine();
			}
			Console.WriteLine();

			Console.WriteLine("7)");
			Console.WriteLine();

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if (i % 2 == j % 2)
					{
						Console.Write("+ ");
					}
					else
					{
						Console.Write("- ");
					}
				}
				Console.WriteLine();
			} 
#endif

#if HARD_CHESS

			Console.Write("Введите размер доски: ");
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();

			for (int m = 0; m < n; m++) 
			{
				for (int i = 0; i < n; i++) 
				{
					for (int j = 0; j < n; j++) 
					{
						if (m % 2 == j % 2) 
						{
							for (int k = 0; k < n; k++) 
							{
								Console.Write("* ");
							}
						}
						else 
						{
							for (int k = 0; k < n; k++) 
							{
								Console.Write("  ");
							}
						}
					}
					Console.WriteLine();
				}
			}
#endif

		}
	}
}








