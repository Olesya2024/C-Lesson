// Задание 1.  Простые алгоритмы на C#
// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81*/

int a = 891;
int b = (a / 100);
int c = (a % 10);
Console.WriteLine($"{b}{c}");
Console.WriteLine($"[{b}, {c}]");

string name = "Vasia";
int age = 10;
Console.WriteLine($"Hello {name}! Your age is {age}");
Console.WriteLine(age + " ");