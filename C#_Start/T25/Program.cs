int[] GetNumberFromConsole(int cnt)
{
    int[] a = new int[cnt];
    for (int i = 1; i <= cnt; i++)
    {
        a[i - 1] = int.Parse(Console.ReadLine());
    }
    return a;
}
int NewPow(int number, int pow)
{
    if(pow == 0) return 1;
    int res = number;
    for (int i = 2; i <= pow; i++)
    {
        res *= number;
    }
    return res;
}
Console.WriteLine("Введите данные:");
int[] ar = GetNumberFromConsole(2);
Console.WriteLine(NewPow(ar[0], ar[1]));