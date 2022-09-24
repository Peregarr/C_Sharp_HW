
// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/*
double[,] Rand2dArr(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];
    double[,] arr1 = new double[rows, columns];
    double[,] arr2 = new double[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arr1[i, j] = new Random().Next(minValue, maxValue + 1);
            arr2[i, j] = new Random().NextDouble();
            array[i, j] = arr1[i, j] + arr2[i, j];
        }
    }
    return array;
}



void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f2}, ");
        }
        Console.WriteLine("\b\b]");
    }
    
    Console.WriteLine();
}


Console.Write("Input nums of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input nums of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[,] newArray = Rand2dArr(rows, columns, minValue, maxValue);
Show2dArray(newArray);
Console.WriteLine();
*/



// Задача 50. Напишите программу,
//  которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание,
//  что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1, 7] -> такого числа в массиве нет

/*
int[,] Create2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + ", ");
        }
        Console.WriteLine("\b\b]");
    }
    Console.WriteLine();
}

void FindElement(int[,] array, int row, int col)
{
    int n = 0;
    int m = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == row) n = i;
            if (j == col) m = j;
        }
    }
    if (n == row & m == col)
    {
        Console.WriteLine($"В массиве найден элемент {array[n, m]} с индексом {n}, {m} ");
    }
    else
    {
        Console.WriteLine($"Указанного индекса {row}, {col} в данном массиве не существует.");
    }
}

Console.WriteLine();
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение элемента: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Отсчет строк и столбцов начинается с нуля!");
Console.Write("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] newArray = Create2dArray(rows, columns, minValue, maxValue);
Print2dArray(newArray);
FindElement(newArray, row, col);
*/

// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*
int[,] Create2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + ", ");
        }
        Console.WriteLine("\b\b]");
    }
    Console.WriteLine();
}

double[,] AverageInCols(int[,] newArray)
{
    double sum = 0;
    double[,] array = new double[1, newArray.GetLength(1)];
    for (int i = 0; i < newArray.GetLength(1); i++)
    {
        for (int j = 0; j < newArray.GetLength(0); j++)
        {
            sum = newArray[j, i] + sum;
        }
        array[0, i] = sum / newArray.GetLength(0);
    }
    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f1}, ");
        }
        Console.WriteLine("\b\b]");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.Write("Input nums of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input nums of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] newArray = Create2dArray(rows, columns, minValue, maxValue);
Print2dArray(newArray);

Console.Write($"Среднее арифметическое значение столбцов ");
Show2dArray(AverageInCols(newArray));
*/