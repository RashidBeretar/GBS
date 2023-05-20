// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillArray(int[,,] array)
{
    Random rnd = new Random();
    var occupiedvalues_ar = new List<int>();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int q = 0; q < array.GetLength(2); q++)
            {
                int tmp_val = rnd.Next(10, 100);
                while (occupiedvalues_ar.Contains(tmp_val))
                {
                    tmp_val = rnd.Next(10, 100);
                }
                occupiedvalues_ar.Add(tmp_val);
                array[i, j, q] = tmp_val;
            }
}

void PrintArray(int[,,] array)
{
    for (int q = 0; q < array.GetLength(2); q++)
    {
        // Console.WriteLine($"Слой {q}");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, q]}({i}, {j}, {q}) ");
            }
            Console.WriteLine();
        }
        // Console.WriteLine();
    }
}

void T60()
{
    // Console.Clear();
    Console.Write("Введите количество строк: ");
    int x_cnt = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int y_cnt = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество слоёв: ");
    int z_cnt = Convert.ToInt32(Console.ReadLine());

    // x_cnt = 2;
    // y_cnt = 2;
    // z_cnt = 2;

    if (x_cnt * y_cnt * z_cnt > 90) throw new ArgumentException("Слишком много элементов в массиве. Нам не хватит двухзначных чисел");

    int[,,] array = new int[x_cnt, y_cnt, z_cnt];
    FillArray(array);
    PrintArray(array);
}
T60();