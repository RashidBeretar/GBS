// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
void OutputAllNaturalNumberLimit(int N, int X = 1)
{
    if (X != N) OutputAllNaturalNumberLimit(N, X + 1);
    if (X == 1) Console.WriteLine($"{X}");
    else Console.Write($"{X}, ");
}
// OutputAllNaturalNumberLimit(5);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int GetNaturalNumberInterval(int M, int N)
{
    if (M < N) (M, N) = (N, M);
    if (N != M) return N + GetNaturalNumberInterval(M, N + 1);
    return N;
}
// Console.WriteLine(GetNaturalNumberInterval(4, 8));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int AckermanFunction(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return AckermanFunction(n - 1, 1);
    else return AckermanFunction(n - 1, AckermanFunction(n, m - 1));
}
// Console.WriteLine(AckermanFunction(2, 3));
Console.WriteLine(AckermanFunction(3, 2));
// Console.WriteLine(AckermanFunction(3, 4));