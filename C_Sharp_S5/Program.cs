// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

/*
int[] RandArr(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
    return array;
}

void ShowArr(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
    
    Console.Write($"{array[i]}, ");
    
    }
    Console.WriteLine("\b\b]");
}

int FindEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;

    }
    return count;

}

Console.WriteLine();
Console.Write("Enter size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = RandArr(size);
ShowArr(array);
Console.WriteLine($"Amount of even nums is {FindEven(array)}");
Console.WriteLine();
*/


// Задача 36: Задайте одномерный массив,
// заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях(индексах).

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
int[] RandArr(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

void ShowArr(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write($"{array[i]}, ");

    }
    Console.WriteLine("\b\b]");
}

int FindSumEelemOddPos(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = array[i] + sum;
        }
    }
    return sum;

}

Console.WriteLine();
Console.Write("Enter size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = RandArr(size);
ShowArr(array);
Console.WriteLine($"Sum of elements in odd positions is {FindSumEelemOddPos(array)}");
Console.WriteLine();
*/


// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным
// и минимальным элементов массива.

// [3 7 22 2 78] -> 76

/*
double[] RandArr(int size)
{
    double[] array = new double[size];
    double[] arr1 = new double[size];
    double[] arr2 = new double[size];
    for (int i = 0; i < size; i++)
    {

        arr1[i] = new Random().Next(0, 10);
        arr2[i] = new Random().NextDouble();
        array[i] = arr1[i] + arr2[i];

    }
    return array;
}

void ShowArr(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write($"{array[i]:f2}, ");

    }
    Console.WriteLine("\b\b]");
}

double difference(double[] array)
{
    double diff = 0;
    double max = 0;
    double min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        min = max;
        if (array[i] < min) min = array[i];
        diff = max - min;

    }
    return diff;
}

Console.WriteLine();
Console.Write("Enter size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = RandArr(size);
ShowArr(array);
Console.WriteLine($"Difference between max and min elements in array is {difference(array):f2}");
Console.WriteLine();
*/