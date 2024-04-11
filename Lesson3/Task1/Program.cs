//Вычислить значение формулы a*b/c+d, где
// a,b,c,d -некоторые целые числа.Решение 
// оформить в виде функции.

double CalculateFormula(int a, int b, int c, int d) //Функция принимает четыре аргумента: 
//int a, int b, int c, int d. Это переменные, которые представляют собой числовые значения для формулы
{
    double numenator = a * b; //сначала вычисляется числитель формулы (numenator) путем умножение a на b
    int denomenator = c + d; //вычисляется знаменатель формулы (denomenator), который является суммой c и d. 
    double result = numenator / denomenator; //функция вычисляет результат формулы (result), 
    //разделив numenator на denomenator Поскольку numenator может быть дробным числом, 
    //result имеет тип double, чтобы сохранить точность результата
    return result;//функция возвращает значение result.
}

double result = CalculateFormula(1, 2, 3, 4);//Здесь функция вызывается с конкретными значениями для переменных a, b, c, d.

Console.WriteLine(result); //значение выводится в консоль с помощью Console.WriteLine.