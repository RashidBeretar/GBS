// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

string ChooseNextDirectionFillArray(string old_direction)
{
    string direction = "";
    if (old_direction == "") direction = "right";
    if (old_direction == "right") direction = "down";
    if (old_direction == "down") direction = "left";
    if (old_direction == "left") direction = "up";
    if (old_direction == "up") direction = "right";
    return direction;
}

// void FillArrayAlmostSpirally(int[,] array, int row, int col, int val)
// {
//     PrintArray(array);
//     Console.WriteLine();
//     if (array[row, col] == 0)
//     {
//         array[row, col] = val;
//         val++;
//         if (col + 1 < array.GetLength(1)) FillArraySpirally(array, row, col + 1, val);
//         if (row + 1 < array.GetLength(0)) FillArraySpirally(array, row + 1, col, val);
//         if (col - 1 >= 0) FillArraySpirally(array, row, col - 1, val);
//         if (row - 1 >= 0) FillArraySpirally(array, row - 1, col, val);
//     }
// }

void FillArraySpirally(int[,] array, int row = 0, int col = 0, int val = 1, string direction = "right")
{
    if (array[row, col] == 0) array[row, col] = val;

    if (!(
        (col + 1 < array.GetLength(1) && array[row, col + 1] == 0) ||
        (row + 1 < array.GetLength(0) && array[row + 1, col] == 0) ||
        (col - 1 >= 0 && array[row, col - 1] == 0) ||
        (row - 1 >= 0 && array[row - 1, col] == 0)
        )
    )
    {
        // Console.WriteLine("Выходим");
        return;
    }

    if (direction == "right" && col + 1 < array.GetLength(1) && array[row, col + 1] == 0)
    {
        FillArraySpirally(array, row, col + 1, ++val, direction);
    }
    else if (direction == "down" && row + 1 < array.GetLength(0) && array[row + 1, col] == 0)
    {
        FillArraySpirally(array, row + 1, col, ++val, direction);
    }
    else if (direction == "left" && col - 1 >= 0 && array[row, col - 1] == 0)
    {
        FillArraySpirally(array, row, col - 1, ++val, direction);
    }
    else if (direction == "up" && row - 1 >= 0 && array[row - 1, col] == 0)
    {
        FillArraySpirally(array, row - 1, col, ++val, direction);
    }
    else
    {
        FillArraySpirally(array, row, col, val, ChooseNextDirectionFillArray(direction));
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10) Console.Write($"0{array[i, j]} ");
            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void T62()
{
    // Console.Clear();

    Console.Write("Введите количество строк: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int m = Convert.ToInt32(Console.ReadLine());

    // n = 4;
    // m = 6;

    int[,] array = new int[n, m];
    FillArraySpirally(array);
    PrintArray(array);
}
T62();