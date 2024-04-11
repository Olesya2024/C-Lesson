// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

int[] array = { 1, 2, 5, 0, 10, 34 };
PrintArrayReverse(array, array.Length - 1);
    
void PrintArrayReverse(int[] arr, int index)
{
    if (index >= 0)
    {
        Console.Write(arr[index] + " ");
        PrintArrayReverse(arr, index - 1);
    }
}
