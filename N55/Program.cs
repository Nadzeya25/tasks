// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] array = new int[,] {{1, 4, -8 },
                          {41, 12, 8 },
                           {1, 3, 5 },
                           {4, 2, 8 },
                           };

void FillArray(int[,] box)
{
    for (int i = 0; i < box.GetLength(0); i++)
    {
        for (int j = 0; j < box.GetLength(1); j++)
        {
            box[i, j] = array[j, i];
        }
    }
}

int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];

void PrintArray(int[,] box)
{
    for (int i = 0; i < box.GetLength(0); i++)
    {
        for (int j = 0; j < box.GetLength(1); j++)
        {
            Console.Write($"{box[i, j]} \t");
        }
        Console.WriteLine();
    }
}

if (array.GetLength(0) != array.GetLength(1))
{
    Console.WriteLine("замена строк на столбцы в данном массиве не возможна, т.к. это прямоугольный массив");
}
else
{
    FillArray(newArray);
    PrintArray(newArray);
}
