 
//Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце. 

 
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
            box[i, j] = new Random().Next(1, 6);
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

void SumArray(int[,]box)
{
    for (int i = 0; i < box.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < box.GetLength(0); j++)
        {
            sum = box[j,i] + sum;
        }
        Console.Write($" среднее арифметическое элементов {i + 1} столбца равно: {sum / box.GetLength(0)}\t");
        Console.WriteLine();
    }
}

SumArray(array);
