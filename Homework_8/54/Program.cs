// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

int[,] FillArray(int countRow, int countColumn)
{
    int[,] newArray = new int[countRow, countColumn];

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = new Random().Next(0, 9);
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

int[,] GetArrayByMax(int[,] array, int countRow)
{
    for (int m = 0; m <= countRow; m++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)

            {
                if (array[i, j] < array[i, j + 1])
                {
                    int max = array[i, j + 1];
                    array[i, j + 1] = array[i, j];
                    array[i, j] = max;
                }
            }
        }
    }
    return array;
}



Console.WriteLine("Input quantity of rows: ");
int countRow = int.Parse(Console.ReadLine());

Console.WriteLine("Input quantity of columns: ");
int countColumn = int.Parse(Console.ReadLine());

int[,] newArray = FillArray(countRow, countColumn);

PrintArray(newArray);

PrintArray(GetArrayByMax(newArray, countRow));