// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим

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

(int x, int y) GetCoordMin(int[,] array)
{
    var min = (x: 0, y: 0);
    // Console.WriteLine("Ищим мин");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // Console.WriteLine(min);
            if (array[min.x, min.y] > array[i, j])
            {
                // Console.WriteLine("Смена");
                min.x = i;
                min.y = j;
            }
        }
    }
    // Console.WriteLine("Закончили");
    return min;
}

int[,] DeletRowColForCoord(int[,] array, (int x, int y) min)
{
    int[,] result_ar = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int shift_x = 0;
    int shift_y = 0;
    for (int i = 0; i < result_ar.GetLength(0); i++)
    {
        if (i == min.x) shift_x++;
        shift_y = 0;
        for (int j = 0; j < result_ar.GetLength(1); j++)
        {
            if (j == min.y) shift_y++;
            result_ar[i, j] = array[i + shift_x, j + shift_y];
        }
    }
    return result_ar;
}

void T59()
{
    int[,] array = new int[5, 5];

    FillArray(array);
    PrintArray(array);
    Console.WriteLine("");

    var min = GetCoordMin(array);

    Console.WriteLine(min);
    Console.WriteLine("");

    array = DeletRowColForCoord(array, min);
    PrintArray(array);
}
T59();