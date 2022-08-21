// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
/*

Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 == num1)
{
    Console.WriteLine("You entered the equal numbers, try again!");
}
if (num2 < num1)
{
    Console.WriteLine($"First number {num1} more than second number {num2}");
}
if (num1 < num2)
{
    Console.WriteLine($"Second number {num2} more than first number {num1}");
}

*/

// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
/*

Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input three integer number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.WriteLine($"Number {max} is maximum");

*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
/*

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
	Console.WriteLine($"Number {num} an even ");
}
else
{
	Console.WriteLine($"Number {num} an odd");
}

*/

// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
/*

Console.Write("Input number: ");
int numEnd = Convert.ToInt32(Console.ReadLine());

int current = 1;
int sum = 0;
Console.Write("Even numbers ");

while(current <= numEnd)
{
    if (current % 2 == 0)
    {
        Console.Write($"{sum + current}, ");
    }
    current++;
}

*/