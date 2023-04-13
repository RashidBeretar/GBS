// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

string IsHoliday(int a)
{
    if ((a >= 6) && (a <= 7)) return "да";
    return "нет";
}

Console.WriteLine("Введите цифру:");
Console.WriteLine(IsHoliday(int.Parse(Console.ReadLine())));