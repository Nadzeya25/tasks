/*Задача 49: Задайте двумерный массив. Найдите элементы,
 у которых оба индекса чётные, и замените эти элементы на их квадраты. */
Console.WriteLine("Введите количество строк массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов масcива n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[m, n];
void FillArray(int[,] box)
{
    for (int i = 0; i < box.GetLength(0); i++)
    {
        for (int j = 0; j < box.GetLength(1); j++)
        {
            box[i, j] = new Random().Next(-10, 15);
        }
    }
}

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
FillArray(array);
PrintArray(array);
Console.WriteLine();
void CopyFillArray(int[,] box)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                box[i, j] = array[i, j] * array[i, j];
            }
            else
            {
                box[i, j] = array[i, j];
            }
        }
    }
}

int[,] newArray = new int[m, n];
CopyFillArray(newArray);
PrintArray(newArray);
