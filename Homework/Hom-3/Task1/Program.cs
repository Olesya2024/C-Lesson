// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в 
// промежутке от M до N. Использовать рекурсию, 
// не использовать циклы.
//M = 1; N = 5 -> "1, 2, 3, 4, 5"
//M = 4; N = 8 -> "4, 5, 6, 7, 8"
//M = 8; N = 4 -> "8, 7, 6, 5, 4"

Console.WriteLine("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

Numbers(m, n);

void NaturalNumbers(int m, int n, int direction)
{
    if (m == n)
    {
        Console.Write($"{m}");
        return;
    }

    Console.Write($"{m}, ");
    NaturalNumbers(m + direction, n, direction);
}

void Numbers(int m, int n)
{
    if (m < n)
    {
        NaturalNumbers(m, n, 1);
    }
    else if (m > n)
    {
        NaturalNumbers(m, n, -1);
    }
    else
    {
        Console.Write($"{m}"); 
    }
}
