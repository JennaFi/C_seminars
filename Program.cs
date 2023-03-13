// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GenerateArray(int length)
{
    int[] array = new int[length];
    Random myRandom = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = myRandom.Next(100, 999);
    }
    return array;
}

void showArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write("{0} ", item);
    }
}

int GetCountEvenNum(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }

    return count;
}


Console.WriteLine("Input length: ");
int length = int.Parse(Console.ReadLine());
int[] array = GenerateArray(length);

showArray(array);
Console.WriteLine("");

int result = GetCountEvenNum(array);
Console.WriteLine(result);

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.

int[] GenerateArray(int length)
{
    int[] array = new int[length];
    Random myRandom = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = myRandom.Next(100, 999);
    }
    return array;
}

void showArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write("{0} ", item);
    }
}

int GetSumOddIndex(int[] array)
{   
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 !=0)
        {
          sum = sum + array[i];  
        }
    }
    return sum;
}

Console.WriteLine("Input length: ");
int length = int.Parse(Console.ReadLine());
int[] array = GenerateArray(length);

showArray(array);
Console.WriteLine("");

int result = GetSumOddIndex(array);
Console.WriteLine(result);

// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] GenerateDoubleArray(int length)
{
    double[] array = new double[length];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.NextDouble();
    }
    return array;
}

void showArray(double[] array)
{
    foreach (var item in array)
    {
        Console.Write("{0:F2} ", item);
    }
}


double GetDifference(double[] array)
{
    double sum = 0;
    double min = array[0];
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
           
        }

        else if (array[i] < min)
        {
            min = array[i];
       
        };

        

        sum = (max - min);
       

    }
    
    return sum;
   


}


Console.WriteLine("Input length: ");
int length = int.Parse(Console.ReadLine());

double[] array = GenerateDoubleArray(length);

showArray(array);
Console.WriteLine("");


double result = GetDifference(array);
Console.WriteLine("The difference = " + result);

