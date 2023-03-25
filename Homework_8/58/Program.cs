// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillArray(int countRow, int countColumn)
{
    int[,] newArray = new int[countRow, countColumn];

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = new Random().Next(0, 3);
            Console.Write(newArray[i, j] + " ");

        }
        Console.WriteLine();
    }
    return newArray;
}

void PrintArray(int[,] newArray)
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


int[,] GetMultipleArray(int[,] firstArray, int[,] secondArray)
{
    int[,] multiArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];

    if (firstArray.GetLength(0) == secondArray.GetLength(1))
    {
        for (int i = 0; i<firstArray.GetLength(0); i++)
        {
            for (int j = 0; j < secondArray.GetLength(1); j++)
            {
                for (int m = 0; m < secondArray.GetLength(0); m++)
                {
                    multiArray[i, j] = firstArray[i, m] * secondArray[m, j];
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Invalid data of array");
    }
    return multiArray;
}


Console.WriteLine("Input quantity of rows of the first table: ");
int countRowOne = int.Parse(Console.ReadLine());
Console.WriteLine("Input quantity of columns of the first table:: ");
int countColumnOne = int.Parse(Console.ReadLine());

Console.WriteLine("Input quantity of rows of the second table: ");
int countRowTwo = int.Parse(Console.ReadLine());
Console.WriteLine("Input quantity of columns of the second table:: ");
int countColumnTwo = int.Parse(Console.ReadLine());


int[,] firstArray = FillArray(countRowOne, countColumnOne);
int[,] secondArray = FillArray(countRowTwo, countColumnTwo);

PrintArray(firstArray);
Console.WriteLine();
PrintArray(secondArray);

int[,] multipleArrays = GetMultipleArray(firstArray, secondArray);
PrintArray(multipleArrays);
