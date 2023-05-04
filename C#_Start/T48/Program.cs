int[,] CreateTwoDimensionArray(int firstLength, int secondLength)
{
    int[,] array = new int[firstLength, secondLength];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);

    return array;
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

int[,] T49(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        if (i % 2 == 0)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j % 2 == 0) array[i, j] = array[i, j] * array[i, j];
            }
        }

    return array;
}

int T51(int[,] array)
{
    var sum = 0;
    int Length = array.GetLength(0);
    if (Length > array.GetLength(1)) Length = array.GetLength(1);
    for (int i = 0; i < Length; i++)
        sum += array[i, i];

    return sum;
}

var array = CreateTwoDimensionArray(4, 3);

PrintArray(array);
Console.WriteLine();
Console.WriteLine(T51(array));