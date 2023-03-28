// Задача 3: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29
// Ak(m-1,1);
// Ak(m-1, Ak(m, n-1))
int Message(string message)
{
    Console.WriteLine(message);
    string contest = Console.ReadLine();
    int number = int.Parse(contest);
    return number;
}

int Akkermann(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (M != 0 && N == 0)
    {
        return Akkermann(M - 1, 1);
    }
    else
        return Akkermann(M - 1, Akkermann(M, N - 1));
}


int M = Message("Input first number: ");
int N = Message("Input second number: ");

int result = Akkermann(M, N);
Console.WriteLine(result);