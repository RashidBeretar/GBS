void FillArray(int[] nums, int minValue = -9, int maxValue = 9)
{
    maxValue++;
    Random rnd = new Random();
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = rnd.Next(minValue, maxValue);
    }
}
void DoubleFillArray(double[] nums, int minValue = -99, int maxValue = 99)
{
    maxValue++;
    Random rnd = new Random();
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = rnd.Next(minValue, maxValue);
    }
}
void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}
void DoublePrintArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}

// Задача 34: Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
void Task34()
{
    Console.WriteLine("Введите количество элементов в массиве:");
    int length = Convert.ToInt32(Console.ReadLine());
    if (length < 0)
    {
        Console.WriteLine("Ошибка! Отрицательного количества быть не может");
        return;
    }
    int[] array = new int[length];
    FillArray(array, 100, 999);
    Console.WriteLine("Получился массив:");
    PrintArray(array);

    int cnt_even = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] % 2 == 0) cnt_even++;
    }
    Console.WriteLine($"Количество чётных чисел в массиве: {cnt_even}");
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
void Task36()
{
    Console.WriteLine("Введите количество элементов в массиве:");
    int length = Convert.ToInt32(Console.ReadLine());

    if (length < 0)
    {
        Console.WriteLine("Ошибка! Отрицательного количества быть не может");
        return;
    }

    Console.WriteLine("Введите минимальное значение диапазона случайных чисел:");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите максимальное значение диапазона случайных чисел:");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    if (minValue > maxValue) (minValue, maxValue) = (maxValue, minValue);

    int[] array = new int[length];
    FillArray(array, minValue, maxValue);
    Console.WriteLine("Получился массив:");
    PrintArray(array);

    int sum_indodd = 0;
    for (int i = 0; i < length; i++)
    {
        if (i % 2 != 0) sum_indodd += array[i];
    }
    Console.WriteLine($"Сумма элементов с нечётными индексами: {sum_indodd}");
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3,21 7,04 22,93 -2,71 78,24] -> 80,95
void Task38()
{
    Console.WriteLine("Введите количество элементов в массиве:");
    int length = Convert.ToInt32(Console.ReadLine());

    if (length < 0)
    {
        Console.WriteLine("Ошибка! Отрицательного количества быть не может");
        return;
    }

    Console.WriteLine("Введите минимальное значение диапазона случайных чисел:");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите максимальное значение диапазона случайных чисел:");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    if (minValue > maxValue) (minValue, maxValue) = (maxValue, minValue);

    double[] array = new double[length];
    DoubleFillArray(array, minValue, maxValue);
    Console.WriteLine("Получился массив:");
    DoublePrintArray(array);

    double min = 0;
    double max = 0;
    for (int i = 0; i < length; i++)
    {
        if (i == 0)
        {
            min = array[i];
            max = array[i];
        }
        min = (array[i] < min) ? array[i] : min;
        max = (array[i] > max) ? array[i] : max;
    }
    
    double diff = max - min;
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {diff}");
}

Task38();