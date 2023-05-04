void FillArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(0, 10);
}
double[,] CreateRandomTwoDimensionArray(int firstLength = 3, int secondLength = 4, double begin_interval = -10, double end_interval = 10)
{
    double[,] array = new double[firstLength, secondLength];
    Random rnd = new Random();
    if (begin_interval > end_interval) (begin_interval, end_interval) = (end_interval, begin_interval);
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Math.Round(rnd.NextDouble() * (end_interval - begin_interval) + begin_interval, 1);

    return array;
}
void PrintArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}
void PrintArrayInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

//  Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//  m = 3, n = 4.
//  0,5 7 -2 -0,2
//  1 -3,3 8 -9,9
//  8 7,8 -7,1 9
void T47()
{
    Console.Write("Введите количество строк: ");
    int firstLength = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int secondLength = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите начало диапазона случайных чисел: ");
    double begin_interval = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите конец диапазона случайных чисел: ");
    double end_interval = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Получили массив: ");
    PrintArrayDouble(CreateRandomTwoDimensionArray(firstLength, secondLength, begin_interval, end_interval));
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
void T50_1()
{
    double[,] array = CreateRandomTwoDimensionArray();
    Console.WriteLine("Массив:");
    PrintArrayDouble(array);
    int firstLength = array.GetLength(0);
    int secondLength = array.GetLength(1);

    Console.WriteLine("Введите позиции элемента:");
    Console.Write("Строка: ");
    int index_i = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.Write("Столбец: ");
    int index_j = Convert.ToInt32(Console.ReadLine()) - 1;

    if (index_i > firstLength - 1 || index_j > secondLength - 1)
    {
        Console.WriteLine("такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine(array[index_i, index_j]);
    }

    // double GetElementTwoDimensionArray();
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
void T50_2()
{
    double[,] array = CreateRandomTwoDimensionArray();
    Console.WriteLine("Массив:");
    PrintArrayDouble(array);
    int firstLength = array.GetLength(0);
    int secondLength = array.GetLength(1);

    Console.WriteLine("Введите позицию элемента:");
    int index = Convert.ToInt32(Console.ReadLine());

    if (index > firstLength * secondLength || index == 0)
    {
        Console.WriteLine("такого числа в массиве нет");
    }
    else
    {
        int index_i = index / secondLength;
        int index_j = index % secondLength;
        if (index_j == 0)
        {
            index_i -= 1;
            index_j = secondLength - 1;
        }
        else
        {
            index_j -= 1;
        }
        Console.WriteLine(array[index_i, index_j]);
    }
}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void T52()
{
    Console.Write("Введите количество строк: ");
    int firstLength = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int secondLength = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[firstLength, secondLength];
    FillArray(array);
    Console.WriteLine("Массив:");
    PrintArrayInt(array);
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < secondLength; j++)
    {
        int sum = 0;
        for (int i = 0; i < firstLength; i++)
        {
            sum += array[i, j];
        }
        double avg = Math.Round(Convert.ToDouble(sum) / firstLength, 1);
        Console.Write(avg);
        if (j == secondLength - 1) Console.Write(".");
        else Console.Write("; ");
    }
}
T47();
// T50_1();
// T50_2();
// T52();