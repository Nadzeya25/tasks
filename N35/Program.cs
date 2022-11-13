/*Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. */

void FillArray(int[] box) // метод заполняет массив
{
    //  
    int size = box.Length;
    for (int index = 0; index < size; index++)
    {
        box[index] = new Random().Next(-20, 200);    //заполняем числами 
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
int[] array = new int[123]; // 8 количество элементов - размер массива
FillArray(array);   //заполняет массив 
PrintArray(array);

void SumInt(int[] box)   
{
    int count = 0;
    int size = box.Length;
    for (int index = 0; index < size; index++)
    {
        if (box[index] > 9 && box[index] < 100)
        {
            count++;
        }
        
    }
    Console.WriteLine(count);
}

System.Console.WriteLine();
SumInt(array);


