// Задание 2.  Простые алгоритмы на C#
// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1*/

//double result = Math.Pow(8, 7);
//System.Console.WriteLine(result);


int a = 487;

int y = a % 10;
int x = a / 10 % 10;

int pow = 1;
for (int i = 0; i < y; i++)
{
    //pow = pow * x;
    pow *= x;
}


/*int count = 0;
while (count < y)
{
    pow = pow * x;
    count++;
}*/


System.Console.WriteLine(pow);