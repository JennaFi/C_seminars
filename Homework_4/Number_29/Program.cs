// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] array = new int[8];

void fillArray(int count)
{
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next();
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("");
}

fillArray(array.Length);
