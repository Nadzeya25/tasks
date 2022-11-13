// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет. 

Console.Write("Введите индекс строки i для поиска элемента: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца j для поиска элемента : ");
int j = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[,] {{1, 4, -8, 0},
                          {41, 12, 8, 1},
                           {1, 3, 5, 6 }
                           };


if (i < 0
 || i > array.GetLength(0)
 || j < 0
 || j > array.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"В данной позиции находится элемент {array[i, j]}");
}





