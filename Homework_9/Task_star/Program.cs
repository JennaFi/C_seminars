int Message(string message)
{
    Console.WriteLine(message);
    string contest = Console.ReadLine();
    int number = int.Parse(contest);
    return number;
}

int [] FillArray (int number)
{
    int[] myArray = new int[number];

    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(-9, 10);
      
    }
    return myArray;

}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}


int GetSecondMax(int[] array)
{
    int max = array[0];
    int second_max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Max is: {max}");
    
    

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > second_max && array[i] < max)
        {
            second_max = array[i];
        }
    }

    return second_max;
}

int number = Message("Input numbers of elements: ");

int[] newArray = FillArray(number);
PrintArray(newArray);


int result = GetSecondMax(newArray);
Console.Write($"The second max in array is: {result}");







