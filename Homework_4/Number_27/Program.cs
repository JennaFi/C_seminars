// Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе.

int SumNumber(int number)
{
    int sum = 0;

    int newNumber = number;

    while (newNumber !=0)
    {
        int digit = newNumber % 10;
        newNumber = newNumber / 10;
        sum = sum + digit;
    }
    
    return sum;
}
Console.WriteLine("Input number: ");
int number = int.Parse(Console.ReadLine());

int sum = SumNumber(number);

Console.WriteLine(sum);