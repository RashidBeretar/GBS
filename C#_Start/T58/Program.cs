// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FillArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(0, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0)) throw new ArgumentException("Ошибка! Две матрицы можно перемножить между собой тогда и только тогда, когда количество столбцов первой матрицы равно количеству строк второй матрицы");

    int[,] result_matrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
        for (int j = 0; j < matrix2.GetLength(1); j++)
            for (int q = 0; q < matrix1.GetLength(1); q++)
                result_matrix[i, j] += matrix1[i, q] * matrix2[q, j];

    return result_matrix;
}

void T58()
{
    // Console.Clear();
    int[,] matrix1 = new int[2, 4];
    int[,] matrix2 = new int[4, 4];

    FillArray(matrix1);
    FillArray(matrix2);

    PrintArray(matrix1);
    Console.WriteLine("");

    PrintArray(matrix2);
    Console.WriteLine("");

    PrintArray(MultiplicationMatrix(matrix1, matrix2));
}
T58();