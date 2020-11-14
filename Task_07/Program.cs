/*
 * Задача : 
 * Написать программу с использованием двух методов. Первый метод возвращает дробную и целую часть числа. 
 * Второй метод возвращает квадрат и корень из числа. В основной программе пользователь вводит дробное число. 
 * Программа должна вычислить, если это возможно, значение корня, квадрата числа, выделить целую и дробную 
 * часть из числа. Выводить и вводить с точностью до 2-х знаков после запятой.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 10,12
 * -------test_2-------
 * -5,5
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 3,18
 * 102,41
 * 10
 * 12
 * -------test_2-------
 * 27,5
 * -5
 * -5
 * --------------------
 */

using System;
using System.Globalization;

namespace Task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO : Сменить локаль на "ru-RU". 
            CultureInfo.CurrentCulture = new CultureInfo("ru-RU");

            double x;
            // TODO : Считать вещественную переменную.
            x = double.Parse(Console.ReadLine());

            int integer, fraction;
            GetIntAndFract(x, out integer, out fraction);

            double sqrt, sqr;
            GetSqrtAndSqr(x, out sqrt, out sqr);

            // TODO : Вывести результаты.
            if (!double.IsNaN(sqrt))
                Console.WriteLine("{0:f2}", sqrt);
            Console.WriteLine("{0:f2}", sqr);
            Console.WriteLine(integer);
            Console.WriteLine(fraction);

            //Console.ReadLine();

        }

        static void GetIntAndFract(double x, out int integer, out int fraction)
        {
            // TODO : Получить целую и дробную часть числа и положить их в соответствующие переменные.
            integer = (int)x;
            fraction = (int)(Math.Round((x - integer), 2)*100);
            if (fraction % 10 == 0)
                fraction /= 10;
        }

        static void GetSqrtAndSqr(double x, out double sqrt, out double sqr)
        {
            // TODO : Посчитать корень и квадрат и записать их в переменные sqrt и sqr соответственно.
            sqrt = x >= 0 ? Math.Sqrt(x) : double.NaN;
            sqr = x * x;
        }
    }
}
