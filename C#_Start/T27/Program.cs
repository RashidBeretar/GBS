int[] GetNumberFromConsole(int cnt)
{
    int[] a = new int[cnt];
    for (int i = 1; i <= cnt; i++)
    {
        a[i - 1] = int.Parse(Console.ReadLine());
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