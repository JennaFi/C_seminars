// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4-> 16

int exponentNumber (int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result *= a;
    }
    return result;
}

Console.Write("Input number A: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Input number B: ");
int b = int.Parse(Console.ReadLine());

int numberRaised = exponentNumber(a, b);
Console.Write(numberRaised);

