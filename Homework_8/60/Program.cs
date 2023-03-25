// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] Get3DArray(int x, int y, int z)
{
    int[,,] newArray = new int[x, y, z];

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            for (int k = 0; k < newArray.GetLength(2); k++)
            {
                newArray[i, j, k] = new Random().Next(0, 9);

            }

        }
        Console.WriteLine();
    }
    return newArray;
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}: {(i, j, k)}");
            }
        }
    }
}


Console.WriteLine("Input X: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Input Y: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Input Z: ");
int z = int.Parse(Console.ReadLine());

int[,,] newArray = Get3DArray(x, y, z);

Print3DArray(newArray);

