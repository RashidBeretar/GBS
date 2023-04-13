// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int GetThirdDigit(int a)
{
    if (a < 0) a *= -1;
    if (a < 100) return -1;
    while (a > 999)
    {
        a /= 10;
    }
    return a % 10;
}

Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());

int result = GetThirdDigit(a);

if (result == -1)
    Console.WriteLine("Третьей цифры нет");
else
    Console.WriteLine(result);