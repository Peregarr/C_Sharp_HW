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

// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

/*
bool findWeekend(int num, int b, int c)
{
    if ((num >= b) & (num <= c))
        return true;
    return false;
}
int a = 1;
int b = 6;
int c = 7;

Console.Write("Enter a number for the day of the week: ");
int num = Convert.ToInt32(Console.ReadLine());

bool res = findWeekend(num, b, c);

if (c < num)
{
    Console.Write("There is no such day of the week");
    
}
else if (num < a)
{
    Console.Write("There is no such day of the week");
    
}
else if (res)
{
    Console.WriteLine($"Number {num} is weekend");
}
else
{
    Console.WriteLine($"Number {num} is not weekend");
}
*/



