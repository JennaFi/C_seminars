// Задача 1: Задайте значение N. Напишите программу, 
// которая выведет все четные натуральные числа в промежутке от m до N . Выполнить с помощью рекурсии.

// M, N = 5, 8 -> "6, 8"
// M, N = 2, 4 -> "2, 4"

int Message(string message) 
{
    Console.WriteLine(message); 
    string contest = Console.ReadLine();
    int number = int.Parse(contest);
    return number;
}

void GetEvenNumbers(int M, int N)
{
    if (M > N)
    {
        return;
    }

    if (M % 2 == 0)
    {
        Console.Write($"{M}, ");
    }
    
    GetEvenNumbers(M +1, N);
}

int M = Message("Input first number: ");
int N = Message("Input second number: ");

GetEvenNumbers(M, N);

