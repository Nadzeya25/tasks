//Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.


int[,] array = new int[,] {{1, 4, -8, 0},
                          {41, 12, 8, 1},
                           {1, 3, 5, 6 }
                           };

void NewArray(int[,] box)
{
    int row1 = 0;
    int row2 = array.GetLength(0) - 1;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[row1, j];
        array[row1, j] = array[row2, j];
        array[row2, j] = temp;
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

NewArray(array);
PrintArray(array);
Console.WriteLine();


