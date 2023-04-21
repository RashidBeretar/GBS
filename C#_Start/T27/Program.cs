// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int[] GetNumberFromConsole(int cnt)
{
    int[] a = new int[cnt];
    for (int i = 0; i < cnt; i++)
    {
        a[i] = int.Parse(Console.ReadLine());
    }
    return a;
}
int GetSumDigitFromNumber(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number /= 10;
        Console.WriteLine(number);
    }
    return result;
}
Console.WriteLine("Введите данные:");
Console.WriteLine(GetSumDigitFromNumber(GetNumberFromConsole(1)[0]));