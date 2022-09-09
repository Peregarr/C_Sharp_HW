
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
int powNum(int a, int b)
{
    int num = 1;
    for (int count = 0; count < b; count++)
    {
        num = a * num;
    }
    return num;
}

Console.Write("Enter first num: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second num: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{a}^{b} = {powNum(a,b)}");
*/


// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*
void FindSum(int num)
{
    int res = 0;
    while (num > 0)
    {
        
        int num1 = num - num % 10;
        res = res + (num - num1);

        num = num / 10;
        
    }
    
    Console.Write(res);
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
FindSum(num);
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

/*
int[] UserArray(int size)
{
    int[] arr = new int[size];
    if (size < 1)
    {
        Console.WriteLine("Enter min value 1");
    }
    for(int i = 0; i < arr.Length; i++)
    {

        Console.Write("Enter the number: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write($"[");
    for(int i = 0; i < arr.Length; i++)
    Console.Write($"{arr[i]}, ");
    Console.WriteLine($"\b\b]");
}

Console.Write("Enter array size: ");
int size = Convert.ToInt32(Console.ReadLine());
PrintArray(UserArray(size));
*/