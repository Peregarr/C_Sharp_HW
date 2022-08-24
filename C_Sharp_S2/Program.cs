// Задача 10: Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

/*
int findSecNum(int num)
{
    int secondThird = num % 100;
    int second = secondThird / 10;
    return second;
}

Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = findSecNum(num);
Console.Write($"Second number is {result} of {num}");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

/*
void showThirdNum(int num)
{
    if (num < 100)
    {
        Console.WriteLine("No third digit");
    }
    else
    {
    while(num > 999)
    {
       num = num / 10;
    }
    num = num % 10;
    Console.WriteLine($"Third number is {num}");
    }
}

Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

showThirdNum(num);
*/




