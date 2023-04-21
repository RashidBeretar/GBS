// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GenArr(int length, int rand_min_val, int rand_max_val)
{
    Random random = new Random();
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(rand_min_val, rand_max_val + 1);
    }
    return array;
}
void PrintArray(int[] ar)
{
    // string mes = string.Empty;
    string mes = "[";
    int length = ar.Length;
    for (int i = 0; i < length; i++)
    {
        mes += ar[i];
        if (i < length - 1) mes += ", ";
    }
    mes += "]";
    Console.WriteLine(mes);
}
Console.WriteLine("Введите количество элементов:");
int length = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение Рандома:");
int rand_min_val = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение Рандома:");
int rand_max_val = int.Parse(Console.ReadLine());
PrintArray(GenArr(length, rand_min_val, rand_max_val));