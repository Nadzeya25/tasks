//Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

Console.WriteLine("Введите количество строк первой матрицы m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк второй матрицы m1: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы n1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array1 = new int[m, n];
int[,] array2 = new int[m1, n1];
void FillArray(int[,] box)
{
    for (int i = 0; i < box.GetLength(0); i++)
    {
        for (int j = 0; j < box.GetLength(1); j++)
        {
            box[i, j] = new Random().Next(-3, 3);
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
int[,] prodArray = new int[m, n1];
void ProductMatrix(int[,] box)
{
    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n1; ++j)
        {
            prodArray[i, j] = 0;
            for (int k = 0; k < m1; ++k)
            {
                prodArray[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    Console.WriteLine();
}

if (n != m1)
{
    Console.WriteLine("Матрицы не возможно перемножить, проверьте размеры матриц");
}
else
{
    Console.WriteLine("первая матрица:");
    FillArray(array1);
    PrintArray(array1);
    Console.WriteLine();
    Console.WriteLine("вторая матрица:");
    FillArray(array2);
    PrintArray(array2);
    System.Console.WriteLine();
    Console.WriteLine("произведение матриц:");
    ProductMatrix(prodArray);
    PrintArray(prodArray);
}





