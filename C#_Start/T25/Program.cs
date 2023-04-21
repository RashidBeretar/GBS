// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int[] GetNumberFromConsole(int cnt)
{
    int[] a = new int[cnt];
    for (int i = 0; i < cnt; i++)
    {
        a[i] = int.Parse(Console.ReadLine());
    }
    return a;
}
int NewPow(int number, int pow)
{
    // if(pow == 0) return 1;
    // int res = number;
    // for (int i = 2; i <= pow; i++)
    // {
    //     res *= number;
    // }
    // return res;

    int res = 1;
    for (int i = 0; i < pow; i++)
    {
        res *= number;
    }
    return res;
}
Console.WriteLine("Введите данные:");
int[] ar = GetNumberFromConsole(2);
if(ar[1] >= 0) 
{
    Console.WriteLine(NewPow(ar[0], ar[1]));
}
else
{
    Console.WriteLine("Всё плохо шеф");
}