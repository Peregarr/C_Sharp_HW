// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


//Решение 1
/*
void FindPalindrom(int num)
{
    int n = num;
    int rev = 0;
    while (num > 0)
    {
        int num1 = num % 10;
        rev = rev * 10 + num1;
        num = num / 10;
    }

    if (n == rev)
    {
        Console.WriteLine($"Введённое число является палиндромом");
    }
    else
    {
        Console.WriteLine("Введённое число НЕ является палиндромом");
    }

}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
FindPalindrom(num);
*/

/*
//Решение 2
void FindPalindrom(int num)
{
    if (num < 10000)
    {
        Console.WriteLine("Минимальным должно быть пятизначное число");
    }
    else if (num > 99999)
    {
        Console.WriteLine("Максимальным должно быть пятизначное число");
    }
    else
    {
        int num1 = num % 10;
        int num2 = num / 10;
        int num3 = num2 % 10;
        int num4 = num2 / 10;
        int num5 = num4 % 10;
        int num6 = num4 / 10;
        int num7 = num6 % 10;
        int num8 = num6 / 10;
        int num9 = num8 % 10;
//      Console.WriteLine($"Ваше число {num}, перевернутое число {num1}{num3}{num5}{num7}{num9}");
        string reverseNum = $"{num1}{num3}{num5}{num7}{num9}";
        int rev = Convert.ToInt32(reverseNum);


        if (num == rev)
        {
            Console.WriteLine("Введённое число является палиндромом");
        }
        else
        {
            Console.WriteLine("Введённое число не является палиндромом");
        }
    }

}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
FindPalindrom(num);

*/


// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*
double LenSegment(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double dotx = x1 - x2;
    double doty = y1 - y2;
    double dotz = z1 - z2;
    return Math.Sqrt(dotx*dotx + doty*doty + dotz*dotz);
    
}


Console.Write("Введите х координату 1 точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y координату 1 точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z координату 1 точки: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите х координату 2 точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y координату 2 точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z координату 2 точки: ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Длина отрезка ({x1},{y1},{z1}) ({x2},{y2},{z2}) равна {LenSegment(x1, y1, z1, x2, y2, z2)}");
LenSegment(x1, y1, z1, x2, y2, z2);
*/



// Задача 23

// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

/*
void cubeTables(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"Куб числа {count} = {count*count*count}");
        count++;
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
cubeTables(num);
*/