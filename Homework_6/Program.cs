// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3

int GetPositiveNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;

}

Console.Write("Input numbers:  ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int result = GetPositiveNumbers(array);

Console.WriteLine($"Numbers of positive elements: {result}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

void GetPointCross(double b1, double b2, double k1, double k2)
{
    double x = -(b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;

    x = Math.Round(x, 2);
    y = Math.Round(y, 2);

   
    Console.WriteLine($"Cross point in the coordinates: ({x}; {y})");
}

Console.WriteLine("Input b1: ");
double b1 = int.Parse(Console.ReadLine());

Console.WriteLine("Input b2: ");
double b2 = int.Parse(Console.ReadLine());

Console.WriteLine("Input k1: ");
double k1 = int.Parse(Console.ReadLine());

Console.WriteLine("Input k2: ");
double k2 = int.Parse(Console.ReadLine());

GetPointCross(b1, b2, k1, k2);



