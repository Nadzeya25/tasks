/*Задача 48: Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран. 
m = 3, n = 4. */
Console.WriteLine("Введите количество строк массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов масива n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,]array = new int [m,n];
void FillArray(int[,]box)
{
    for (int i = 0; i < box.GetLength(0); i++)
    {
        for (int j = 0; j < box.GetLength(1); j++)
        {
            box[i, j] = i+j;
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

