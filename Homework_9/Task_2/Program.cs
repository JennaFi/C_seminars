// Задача 2: Задайте значения M и N.
//  Напишите программу, которая найдёт сумму 
//  натуральных элементов в промежутке от M до N.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

int Message(string message)
{
    Console.WriteLine(message);
    string contest = Console.ReadLine();
    int number = int.Parse(contest);
    return number;
}

void GetSumBetween(int M, int N, int sum = 0)
{
    if (M > N)
    {
        return;
    }

    if (M == N)
    {
        sum += M;
        Console.WriteLine($"The sum between M and N is: {sum}");
    }
    sum = sum + M;
    GetSumBetween(M+1, N, sum);

}



int M = Message("Input first number: ");
int N = Message("Input second number: ");

GetSumBetween(M, N);