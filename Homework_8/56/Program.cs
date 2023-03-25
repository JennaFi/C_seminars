// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


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


int GetMinSumByRow(int[,] array)
{
    int sum = 0;
    int minSumRow = 0;
    int tempSum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0)
            {
                tempSum = sum;
                minSumRow = i + 1;
            }

            sum = sum + array[i, j];   

        }

        if (sum < tempSum)
        {
            tempSum = sum;
            minSumRow = i + 1;
        }
        sum = 0;
    }
    return minSumRow;

}



int countRow = 3;
int countColumn = 4;
int[,] newArray = FillArray(countRow, countColumn);
PrintArray(newArray);

int result = GetMinSumByRow(newArray);
Console.WriteLine($"Min sum is: {result}");