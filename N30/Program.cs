/*Задача 30: Напишите программу, которая выводит массив из 8 элементов,
 заполненный нулями и единицами в случайном порядке. 
[1,0,1,1,0,1,0,0] */

void FillArray(int[] box)
{
    int size = box.Length;
    for (int i = 0; i < size; i++)
    {
        box[i] = new Random().Next(0,2);
    }
}
void PrintArray(int[] box)
{
    int size = box.Length;
    for (int i = 0; i < size; i++)
    {
        if (i == size - 1)
        {
            Console.Write($"{box[i]}, ]");
        }
        else
        {
            Console.Write($"{box[i]}, ");
        }
    }
}
int[]array = new int[8];
Console.Write("[ ");
FillArray(array);
PrintArray(array);

