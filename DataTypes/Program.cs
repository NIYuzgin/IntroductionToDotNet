#define DATATYPES
//#define CONSTANTS
//#define TYPE_CONVERSIONS



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

			Console.WriteLine(
$@"short занимает {sizeof(short)} байт памяти,
и принимает значения в диапазоне от {short.MinValue} до {short.MaxValue},
класс обвертка {typeof(short)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
$@"ushort занимает {sizeof(ushort)} байт памяти,
и принимает значения в диапазоне от {ushort.MinValue} до {ushort.MaxValue},
класс обвертка {typeof(ushort)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine(
$@"int занимает {sizeof(int)} байт памяти,
и принимает значения в диапазоне от {int.MinValue} до {int.MaxValue},
класс обвертка {typeof(int)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
$@"uint занимает {sizeof(uint)} байт памяти,
и принимает значения в диапазоне от {uint.MinValue} до {uint.MaxValue},
класс обвертка {typeof(uint)}"
				);
			Console.WriteLine(delimiter);
			
			Console.WriteLine(
$@"long занимает {sizeof(long)} байт памяти,
и принимает значения в диапазоне от {long.MinValue} до {long.MaxValue},
класс обвертка {typeof(long)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
$@"ulong занимает {sizeof(ulong)} байт памяти,
и принимает значения в диапазоне от {ulong.MinValue} до {ulong.MaxValue},
класс обвертка {typeof(ulong)}"
				);
			Console.WriteLine(delimiter);
			
			Console.WriteLine(
$@"float занимает {sizeof(float)} байт памяти,
и принимает значения в диапазоне от {float.MinValue} до {float.MaxValue},
класс обвертка {typeof(float)}"
				);
			Console.WriteLine(delimiter);
			
			Console.WriteLine(
$@"double занимает {sizeof(double)} байт памяти,
и принимает значения в диапазоне от {double.MinValue} до {double.MaxValue},
класс обвертка {typeof(double)}"
				);
			Console.WriteLine(delimiter);
			
			Console.WriteLine(
$@"decimal занимает {sizeof(decimal)} байт памяти,
и принимает значения в диапазоне от {decimal.MinValue} до {decimal.MaxValue},
класс обвертка {typeof(decimal)}"
				);
			Console.WriteLine(delimiter);

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
