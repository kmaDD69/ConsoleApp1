using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение для x:");

            // Считывание введенного числа с клавиатуры
            double x = double.Parse(Console.ReadLine());

            // Вычисление значения функции
            double result = CalculateFunction(x);

            // Вывод результата на экран
            Console.WriteLine($"Значение функции 3Sin(x+2) при x = {x} равно {result}");

            Console.ReadLine();
            Console.ReadKey();
        }
        // Функция для вычисления значения функции 3Sin(x+2)
        static double CalculateFunction(double x)
        {
            return 3 * Math.Sin(x + 2);
        }
    }
}
