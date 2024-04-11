// /*Задание 2. 
// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите целое число N:");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = -n; i <= n; i++)
        {
            Console.Write(i);
            if (i != n)
            {
                Console.Write(", ");
            }
        }
    }
}