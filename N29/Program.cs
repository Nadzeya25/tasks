/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. */

void FillArray(int[] box) // метод заполняет массив
{
    //  
    int size = box.Length;
    for (int index = 0; index < size; index++)
    {
        box[index] = new Random().Next();    //заполняем числами от 1 до 9
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
int[] array = new int[8]; // 8 количество элементов - размер массива
FillArray(array);   //заполняет массив 
PrintArray(array);


