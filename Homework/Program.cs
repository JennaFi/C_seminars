Homework_1

// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"


Console.WriteLine("Input number: ");
int N = int.Parse(Console.ReadLine());

for (int i = -N; i <= N; i++)
{
    Console.WriteLine($"{i}");
}



// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine("Input numbers: ");

int a = int.Parse(Console.ReadLine()); 
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"max = {a}");
}
else 
{
    Console.WriteLine($"max = {b}");
}

// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел.
// Console.WriteLine("Input numbers: ");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int max = a;

if (a > b) 
{
    max = a;
}
else if (b > c)
{
   max = b; 
}
else
{
    max = c;
}
Console.WriteLine($"max = {max}");


// Задача 6: Напишите программу, которая на вход принимает число и выдает,

//  является ли число четным (делится ли оно на два без остатка).


Console.WriteLine("Input number: ");

int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"Number {number} is even");
}
else 
{
    Console.WriteLine($"Number {number} is an odd number");
}


// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Input number: " );

int N = int.Parse(Console.ReadLine());

for (int i = 1; i < N; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"Odd numbers: {i}");
    }
}
