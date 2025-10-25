//#define DATATYPES
//#define CONSTANTS
#define TYPE_CONVERSIONS



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	internal class Program
	{
		const string delimiter = "\n-----------------------------\n";
		static void Main(string[] args)
		{
#if DATATYPES
			Console.WriteLine($"bool занимает {sizeof(bool)} байт памяти, класс обвертка Boolean;");
			Console.WriteLine(bool.FalseString);
			Console.WriteLine(bool.TrueString);
			Console.WriteLine(typeof(bool));

			Console.WriteLine(delimiter);

			//////////////////////////////////////////////////////////

			Console.WriteLine
				(
$@"Тип данных char занимает {sizeof(char)} Байт памяти, и принимает значения
в диапазоне от {(int)char.MinValue} до {(int)char.MaxValue}. Класс-обвертка - {typeof(char)}"
				);

			Console.WriteLine(delimiter);

			// @ - RAW-строка - игнорирует все специальные символы и Esc - последовательности

			Console.WriteLine
				(
				@"RAW-строка - игнорирует все специальные символы и Esc - последовательности \t\n,
				т.е. воспринимается как есть 'as-is'"
				);

			// ushort, uint, ulong
			// sbyte (Signed Byte)
			// sbyte	byte		1 Байт
			// short	ushort		2 Байт
			// int		uint		4 Байт
			// long		ulong		8 Байт

			Console.WriteLine(delimiter);

			Console.WriteLine
				(
$@"byte занимает {sizeof(byte)} байт памяти,
и принимает значения в диапазоне от {byte.MinValue} до {byte.MaxValue},
класс обвертка {typeof(byte)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
$@"sbyte занимает {sizeof(sbyte)} байт памяти,
и принимает значения в диапазоне от {sbyte.MinValue} до {sbyte.MaxValue},
класс обвертка {typeof(sbyte)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
				$@"float занимает {sizeof(float)} байт памяти"
				);
			Console.WriteLine(delimiter); 
			
			Console.WriteLine
				(
				$@"decimal занимает {sizeof(decimal)} байт памяти"
				);
			decimal a = 1;
			//double a = 1;
			a /= 3;
			Console.WriteLine(a);
			a *= 3;
			Console.WriteLine(a);

			Console.WriteLine(delimiter);
#endif

			//////////////////////////////////////////////////

#if CONSTANTS
			Console.WriteLine("Hello".GetType());
			Console.WriteLine(5.GetType());
			Console.WriteLine(5.0.GetType());
#endif

#if TYPE_CONVERSIONS
			int n = 5;
			while (n-- > 0)
			{
				Console.WriteLine(n);
			}

			Console.WriteLine(delimiter);

			//ushort b = 2;
			//Console.WriteLine(b); 

			//int a = 2;
			double a = 2.2;
			short b = (short)a;
			Console.WriteLine(b);
			//bool rain = Convert.ToBoolean("True");
			bool rain = bool.Parse("false");
			Console.WriteLine(rain);

#endif
		}
	}
}
