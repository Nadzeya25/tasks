// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 

Console.WriteLine("Введите количество строк массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов масива n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double[ ,] array = new double[m, n];
void FillArray(double[,]box)
{
    for (int i = 0; i < box.GetLength(0); i++)
    {
        for (int j = 0; j < box.GetLength(1); j++)
        {
            box[i, j] = new Random(). NextDouble();
        }
    }
}

void PrintArray(double[,]box)
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

