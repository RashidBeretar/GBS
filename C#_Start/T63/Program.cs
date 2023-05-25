// T63
void OutputNaturalNumber(int N)
{
    if (N >= 1)
    {
        OutputNaturalNumber(N - 1);
    }
    Console.Write($"{N}, ");
}

// T65
void OutputNaturalNumberInterval(int M, int N)
{
    if (N != M)
    {
        OutputNaturalNumberInterval(M, N - 1);
    }
    Console.Write($"{N}, ");
}

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// 4789
// 9
// 478
// 8
// 47

int T67(int number)
{
    if (number / 10 > 0)
    {
        return number % 10 + T67(number / 10);
    }
    return number % 10;
}
// Console.Write(T67(457));

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int T69(int number, int extent)
{
    if (extent > 0)
    {
        return number * T69(number, extent - 1);
    }
    return 1;
}

// OutputNaturalNumber(5);
OutputNaturalNumberInterval(5, 7);
// Console.Write(T67(457));
// Console.Write(T69(5, 3));