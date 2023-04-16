// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double[] GetArrayFromString(string arrayAsString)
{
    string[] strings = arrayAsString.Split("; ");
    int length = strings.Length;
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = double.Parse(strings[i]);
    }
    return array;
}
double GetDist2Point(double[] A, double[] B)
{
    if (A.Length != B.Length)
    {
        Console.WriteLine("Ошибка! Координаты заданы не верно");
        return -1;
    }
    double forsqrt = 0;
    for (int i = 0; i < A.Length; i++)
    {
        forsqrt += Math.Pow(A[i] - B[i], 2);
    }
    return Math.Sqrt(forsqrt);
}

Console.WriteLine("Введите координаты точки A (3 числа) через \"; \"");
double[] A = GetArrayFromString(Console.ReadLine());
Console.WriteLine("Введите координаты точки B (3 числа) через \"; \"");
double[] B = GetArrayFromString(Console.ReadLine());
Console.WriteLine("Расстояние " + GetDist2Point(A, B));