
//#define CONSOLE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDotNet
{
	internal class Program // internal - модификатор доступа:
						   // сущность доступна в пределах сборки
	{
		static void Main(string[] args)
		{
#if CONSOLE
            Console.WriteLine("Hello World!"); // выводит строку на экран
                                               // и переводит курсор на новую строку
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Hello .NET\t"); // вывод на экран
            Console.WriteLine();
            Console.Title = "Introduction to .NET";
            //Console.Beep(200,2000);
            Console.CursorLeft = 25;
            Console.CursorTop = 5;
            Console.WriteLine("SetCursorPosition");
            Console.SetCursorPosition(22, 8);
            Console.WriteLine("Another position");
            Console.ResetColor();
            //Console.Clear();  
#endif
			Console.Write("Введите Ваше имя: ");
			string firstName = Console.ReadLine();

			Console.Write("Введите Вашу фамилию: ");
			string lastName = Console.ReadLine();

			Console.Write("Введите Ваш возраст: ");
			int age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(lastName + " " + firstName + " " + age); // конкатенация строк
			Console.WriteLine(String.Format("{0} {1} {2}", lastName, firstName, age)); // форматирование строк
			Console.WriteLine($"{lastName} {firstName} {age}"); // интерполяция строк
		}
	}
}
