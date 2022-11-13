/* Задача 31: Задайте массив из 12 элементов, заполненный случайными числами
 из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.*/

void FillArray(int[] box) // метод заполняет массив
{
    //  
    int size = box.Length;
    for (int index = 0; index < size; index++)
    {
        box[index] = new Random().Next(-9, 10);    //заполняем числами от 1 до 9
    }
}
void PrintArray(int[] box)   // метод печатает
{
    int size = box.Length;
    for (int index = 0; index < size; index++)
    {
        if (index == size - 1)
        {
            Console.Write($"{box[index]} ]");
        }
        else
        {
            Console.Write($"{box[index]}, ");
        }
    }
}
Console.Write("[ ");
int[] array = new int[12]; // 12 количество элементов - размер массива
FillArray(array);   //заполняет массив 
PrintArray(array);

int SumMinus(int[] box)
{

    int size = box.Length;
    // int sumPlus = 0;
    int sumMinus = 0;
    for (int index = 0; index < size; index++)
    {
        if (box[index] < 0)
        {
            sumMinus = sumMinus + box[index];
        }

    }
    return sumMinus;
}
Console.WriteLine();
// Console.WriteLine(SumPlus);
int rez1 = SumMinus(array);
Console.WriteLine($"Сумма отрицательных чисел в массиве равна {rez1}");

int SumPlus(int[] box)
{
    int size = box.Length;
    int sumPlus = 0;
    for (int index = 0; index < size; index++)
    {
        if (box[index] > 0)
        {
            sumPlus = sumPlus + box[index];
        }
    }
    return sumPlus;
}
Console.WriteLine();
// Console.WriteLine(SumPlus);
int rez2 = SumPlus(array);
Console.WriteLine($"Сумма положительных чисел в массиве равна {rez2}");
