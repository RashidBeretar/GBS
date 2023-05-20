// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int GetMinSumRowArray(int[,] array)
{
    int num_row = 1;
    int min_sum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }

        if (i == 0) min_sum = sum;

        if (sum < min_sum)
        {
            Console.WriteLine("Смена");
            min_sum = sum;
            num_row = i + 1;
        }
    }

    return num_row;
}

void T56()
{
    // Console.Clear();
    int[,] array = new int[4, 4];

    FillArray(array);
    PrintArray(array);
    Console.WriteLine("");

    Console.WriteLine($"{GetMinSumRowArray(array)} строка");
}
T56();