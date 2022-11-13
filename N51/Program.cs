/*Задача 51: Задайте двумерный массив. Найдите сумму элементов,
 находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д. */

int[,] array = new int[,] {{2, 4, -8, 0},
                          {41, 12, 8, 1},
                           {1, 3, 5, 6 }
                           };

void SumArray(int[,] box)
{
    int count = 0;
    for (int i = 0; i < box.GetLength(0); i++)
    {
        for (int j = 0; j < box.GetLength(1); j++)
        {
            if (i == j)
            {
                count = box[i, j] + count;
            }

        }

    }
    Console.WriteLine(count);
}

SumArray(array);

