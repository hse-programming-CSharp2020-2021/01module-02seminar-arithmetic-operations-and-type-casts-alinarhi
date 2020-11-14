/*
 * Задача : 
 * Ввести натуральное трехзначное число Р. 
 * Найти наибольшее целое число, которое можно получить, переставляя цифры числа Р.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 208
 * -------test_2-------
 * 159
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 820
 * -------test_2-------
 * 951
 * --------------------
 */

using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int p;
            // TODO : Реализовать ввод целочисленного значения.
            p = int.Parse(Console.ReadLine());

            // TODO : Посчиать и вывести результат.
            Console.WriteLine(MaxPermutation(p));
            //Console.ReadLine();
        }

        static int MaxPermutation(int x)
        {
            // TODO : Получить цифры числа используя арифметические операции.
            int number = x;
            int firstDigit = 0,
                secondDigit = 0,
                thirdDigit = 0;
            while (number > 0)
            {
                if (number % 10 > firstDigit)
                {
                    secondDigit = firstDigit;
                    thirdDigit = secondDigit;
                    firstDigit = number % 10;
                }
                else if (number % 10 > secondDigit)
                {
                    thirdDigit = secondDigit;
                    secondDigit = number % 10;
                }
                else if (number % 10 > thirdDigit)
                {
                    thirdDigit = number % 10;
                }
                number /= 10;
            }


            // TODO : Собрать новое число и вернуть его. 
            int max = firstDigit * 100 + secondDigit * 10 + thirdDigit;

            return max;
        }
    }
}
