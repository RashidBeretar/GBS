void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}
int[] GetArrayFromString(string arrayAsString)
{
    string[] strings = arrayAsString.Split(", ");
    int length = strings.Length;
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = Convert.ToInt32(strings[i]);
    }
    return array;
}

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
void Task41()
{
    Console.WriteLine("Введите числа через запятую и пробел:");

    int[] array = GetArrayFromString(Console.ReadLine());
    PrintArray(array);

    int length = array.Length;
    int cnt_positive = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] > 0) cnt_positive++;
    }
    Console.WriteLine($"Количество чисел больше нуля: {cnt_positive}");
}

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
void Task43()
{
    Console.WriteLine("Введите данные:");
    Console.Write("b1 = ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("k1 = ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("b2 = ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("k2 = ");
    double k2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите данные:");
    Console.WriteLine($"Ввели: b1 = {b1};  k1 = {k1};  b2 = {b2};  k2 = {k2}; ");

    if (k1 - k2 == 0)
    {
        Console.WriteLine("Ошибка! k1 - k2 не должно быть равно 0");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
        Console.WriteLine($"({x}; {y})");
    }
}
Task43();