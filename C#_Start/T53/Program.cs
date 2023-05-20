// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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

void T53()
{
    int[,] array = new int[3, 4];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine(array.GetLength(0));
    Console.WriteLine(array.GetLength(1));
    for (int i = 0; i < array.GetLength(0); i++)
    {
        (array[0, i], array[array.GetLength(0) - 1, i]) = (array[array.GetLength(0) - 1, i], array[0, i]);
    }
    PrintArray(array);
}
T53();