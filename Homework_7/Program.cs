// // Задача 47.Задайте двумерный массив размером m×n, 
// // заполненный случайными вещественными числами.

double [,] FillArray(int countRow, int countColumn)
{
    double[,] newArray = new double[countRow, countColumn];

    for(int i = 0; i < countRow; i++)
    {
        for(int j = 0; j < countColumn; j++)
        {
            newArray[i, j] = Math.Round(new Random().NextDouble(), 2);

        }
    }
    return newArray;

}

void PrintArray(double[,] newArray)
{
    Console.WriteLine();
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++) 
        {
            Console.Write($"{newArray[i, j]}  ");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Input quantity of rows: ");
int countRow = int.Parse(Console.ReadLine());

Console.WriteLine("Input quantity of columns: ");
int countColumn = int.Parse(Console.ReadLine());

double[,] newArray = FillArray(countRow, countColumn);
PrintArray(newArray);


// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.


int[,] FillArray(int countRow, int countColumn)
{
    int[,] newArray = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            newArray[i, j] = new Random().Next(0,99);
            Console.Write(newArray[i, j] + " ");

        }
        Console.WriteLine();
    }
    return newArray;
}

void GetElementByIndex(int m, int n, int [,] newArray)
{
    if(m < 0 || n < 0)
    {
        Console.Write("Can not be minus");
    }
    else if(m <= m+1 && n <= n+1)
    {
        Console.Write($"Element is {newArray[m - 1, n - 1]}");
    }
    else
    {
        Console.Write("There is no such element");
    }
}

Console.WriteLine("Input quantity of rows: ");
int countRow = int.Parse(Console.ReadLine());

Console.WriteLine("Input quantity of columns: ");
int countColumn = int.Parse(Console.ReadLine());

int[,] newArray = FillArray(countRow, countColumn);

Console.WriteLine("Input coordinates of the element: ");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

GetElementByIndex(m, n, newArray);


// Задача 52.Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.


int[,] FillArray(int countRow, int countColumn)
{
    int[,] newArray = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            newArray[i, j] = new Random().Next(0,99);
            Console.Write(newArray[i, j] + " ");

        }
        Console.WriteLine();
    }
    return newArray;
}

void GetMidSum(int[,] newArray)
{
    double midSum = 0;
    
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            midSum = midSum + newArray[i, j];
            
        }
        midSum = midSum / newArray.GetLength(0);
        Console.WriteLine(Math.Round((midSum), 2));

    }
   
}

Console.WriteLine("Input quantity of rows: ");
int countRow = int.Parse(Console.ReadLine());

Console.WriteLine("Input quantity of columns: ");
int countColumn = int.Parse(Console.ReadLine());

int[,] newArray = FillArray(countRow, countColumn);

GetMidSum(newArray);