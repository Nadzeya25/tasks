//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Введите количество строк массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов масива n: ");
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


int[] res1 = new int[m];  //массив для хранения сумм строк
int summ1 = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        summ1 += array[i, j];   //суммируем элементы строки
    }
    res1[i] = summ1; //пишем сумму в массив
    summ1 = 0; //обнуляем переменную
}

int min = 0;    //индекс строки с минимальной суммой
for (int j = 1; j < m; j++)
{
    if (res1[j] < res1[min])   //если есть строка с суммой меньше, то пишем в min её индекс
        min = j;
}
Console.WriteLine();
Console.WriteLine($"наименьшую сумму элементов ({res1[min]}) имеет {min+1} строка ");
Console.WriteLine();



// int[] res2 = new int[n];   //то же самое, только для столбцов
// int summ2 = 0;
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         summ2 += B[j, i];  // индексы меняем местами, чтобы просматривались не строки, а столбцы.
//     }
//     res2[i] = summ2;
//     summ2 = 0;
// }

// int min = 0;
// for (int j = 1; j < n; j++)
// {
//     if (res2[j] < res1[min])
//         min = j;
// }

// Console.WriteLine("Номер столбца с минимальной суммой элементов: " + min);
// Console.ReadLine();