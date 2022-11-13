//Задача 54: Задайте двумерный массив. Напишите программу, которая 
//упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] array = new int[,] {{0, 1, 2, 3},
                          {10, 11, 12, 13},
                           {20, 21, 22, 23 }
                           };
int m = array.GetLength(0);//количество строк, длина столбца
int n = array.GetLength(1);//количество столбцов , длина строки

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

PrintArray(array);
Console.WriteLine();

// int[,] sortArray = new int[m, n];
void SortArray(int[,] box)
{
    for (int i = 0; i < box.GetLength(0); i++)
    {
        
   for (int j = n-1; j >= 0; j--)
    {
        int minPosition = j;
        for (int a = j; a >=0; a--)
            if (box[i,a] < box[i,minPosition])
            {
                minPosition = a;
            }
        int temp = box[i,j];
        box[i,j] = box[i,minPosition];
        box[i,minPosition] = temp;
    }
}
}
SortArray(array);
PrintArray(array);


