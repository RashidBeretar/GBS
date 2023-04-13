// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
int GetSecondDigit(int a)
{
    if (a < 0) a *= -1;
    if (a >= 100 && a <= 999)
        return (a % 100) / 10;
    else
        return -1;
}

Console.WriteLine("Введите число:");

int a = int.Parse(Console.ReadLine());

int result = GetSecondDigit(a);

if (result == -1)
    Console.WriteLine("Число не трёхзначное");
else
    Console.WriteLine(result);