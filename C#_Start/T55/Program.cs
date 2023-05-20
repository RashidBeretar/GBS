// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

void T55()
{
    int[,] array = new int[5, 5];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine(array.GetLength(0));
    Console.WriteLine(array.GetLength(1));

    if (array.GetLength(0) != array.GetLength(1))
    {
        // Console.WriteLine("Всё плохо");
        // return;
        throw new ArgumentException("Всё плохо");
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
            (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
    }
    PrintArray(array);
}
T55();