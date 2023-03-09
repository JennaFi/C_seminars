// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Input 3-digit number: ");

int number = int.Parse(Console.ReadLine());

if (number >= 100 && number <= 999) 
{
    int secondDigit = number / 10;
    secondDigit = secondDigit % 10;
    Console.WriteLine($"Second digit: {secondDigit}");
}

else
{
    Console.WriteLine("It's not a 3-digit number");
}


// Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.

Console.WriteLine("Input a number: ");

int number = int.Parse(Console.ReadLine());

while (number > 999)
{
   
    number = (number /  10);
}


if (number <= 999 && number > 99)
{
    // number = number / 10;
    number = number % 10;
    Console.WriteLine($"{number}");
}
else if (number < 99)
{
    Console.WriteLine("There is no third digit");
}
  

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine("Input number of the day: ");

int number = int.Parse(Console.ReadLine());
if (number == 6 || number == 7)
    {
        Console.WriteLine("That's a weekend");
    }
else
{
    Console.WriteLine("That's' a workday");
}








