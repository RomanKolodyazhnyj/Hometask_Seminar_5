// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

var array = FillArray(5);
Print(array);
Console.WriteLine();

int max = Max(array);
int min = Min(array);
Console.WriteLine($"Максимальное значение: {max}, минимальное значение: {min}");

int result = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {result}");

int Max(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) 
        {
            max = array[i];
        }
    }
    return max;
}

int Min(int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i]) 
        {
            min = array[i];
        }
    }
    return min;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(10, 100);
    }
    return array;
}

void Print(int[] array)
{
    foreach(var item in array)
    {
        Console.Write($"{item}, ");
    }
}