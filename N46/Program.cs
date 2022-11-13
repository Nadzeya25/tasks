//Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами. 

Console.WriteLine("Введите количество строк массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов масива n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[ ,] array = new int[m, n];
void FillArray(int[,]box)
{
    for (int i = 0; i < box.GetLength(0); i++)
    {
        for (int j = 0; j < box.GetLength(1); j++)
        {
            box[i, j] = new Random(). Next(-10, 15);
        }
    }
}

void PrintArray(int[,]box)
{
   for (int i = 0; i < box.GetLength(0); i++)
   {
    for (int j = 0; j < box.GetLength(1); j++)
    {
      Console.Write($"{box[i,j]} \t");
    }
    Console.WriteLine();
   } 
}
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"количество строк **m** (длина столбца)GetLength(0) = {array.GetLength(0)}");
Console.WriteLine($"количество столбцов **n** (длина стороки)GetLength(1) ={array.GetLength(1)}");