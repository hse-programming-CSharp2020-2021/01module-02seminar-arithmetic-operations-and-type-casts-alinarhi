/*
 * Задача : 
 * Ввести значение x и вывести значение полинома: F(x) = 12x^4 + 9x^3 - 3x^2 + 2x – 4. 
 * С точностью до 2-х знаков после запятой. 
 * !!! Не применять возведение в степень. !!!
 * Использовать минимальное количество операций умножения. 
 * (Алгоритм быстрого возведения в степень : https://e-maxx.ru/algo/binary_pow)
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 1
 * -------test_2-------
 * 0
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 16,00
 * -------test_2-------
 * -4,00
 * --------------------
 * 
 * Тестирование будет проводиться на машинах с английской локалью, где в качестве разделителя в 
 * вещественных числах используется точка. Чтобы выводилась запятая надо принудительно сменить локаль на русскую.
 */

using System;
using System.Globalization;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("ru-RU");

            double x;
            // Ввод данных. 
            x = double.Parse(Console.ReadLine());

            // Вычисление и вывод данных.
            //akkkkk
            Console.WriteLine($"{Function(x):f2}");
        }

        static double Function(double x)
        {
            return 12 * myPow(x, 4) + 9 * myPow(x, 3) - 3 * myPow(x, 2) + 2 * x - 4;
        }

        static double myPow(double x, int pow)
        {
            if (pow == 0)
                return 1;
            if (pow == 1)
                return x;
            if (pow % 2 != 0)
                return myPow(x, pow - 1) * x;
            var half = myPow(x, pow / 2);
            return half * half;
        }
    }
}
