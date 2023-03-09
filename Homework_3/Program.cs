// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


void palindrome(int number)
{
    int value1 = number / 10000 % 10;
    int value2 = number / 1000 % 10;
    int reverse1 = number / 10 % 10;
    int reverse2 = number % 10;

    if (value1 == reverse2 && value2 == reverse1)
    {
        Console.WriteLine("Yes, it's a palindrome");
        // Console.WriteLine($"{value1}");
        // Console.WriteLine($"{value2}");
        // Console.WriteLine($"{reverse1}");
        // Console.WriteLine($"{reverse2}");
    }
    else
    {
        Console.WriteLine("No, it's not a palindrome");
    }
}

Console.WriteLine("Input a 5-digit number: ");
int number = int.Parse(Console.ReadLine());

palindrome(number);


// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// AB = √((xb - xa)2 + (yb - ya)2) + (zb - zф)2


double distance(double xa, double xb, double ya, double yb, double za, double zb)
{
    double result = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)) + Math.Pow(zb - za, 2);
    return result;
}


Console.WriteLine("Input xa: ");
double xa = double.Parse(Console.ReadLine());

Console.WriteLine("Input ya: ");
double ya = double.Parse(Console.ReadLine());

Console.WriteLine("Input za: ");
double za = double.Parse(Console.ReadLine());

Console.WriteLine("Input xb: ");
double xb = double.Parse(Console.ReadLine());

Console.WriteLine("Input yb: ");
double yb = double.Parse(Console.ReadLine());

Console.WriteLine("Input zb: ");
double zb = double.Parse(Console.ReadLine());

double length = distance(xa, ya, za, xb, yb, zb);

Console.WriteLine("the distance is: " + Math.Round(length, 2));


// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void cube(int x)
{
    for (int i = 1; i <= x; i++)
    {
        if (i == x)
        {
            Console.WriteLine(i * i * i);
            break;
        }
        Console.Write(i * i * i + ", ");
    }
}

Console.Write("Input number: ");
int n = int.Parse(Console.ReadLine());



cube(n);
