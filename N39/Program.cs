/*Задача 39: Напишите программу, которая перевернёт одномерный массив
 (последний элемент будет на первом месте, а первый - на последнем и т.д.) */

void FillArray(int[] box) // метод заполняет массив
{
    //  
    int size = box.Length;
    for (int index = 0; index < size; index++)
    {
        box[index] = new Random().Next(-10, 11);    //заполняем числами от 1 до 9
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
int[] array = new int[10]; // 8 количество элементов - размер массива
FillArray(array);   //заполняет массив 
PrintArray(array);


int[]newAr = new int[array.Length];
void FillCopyArray(int[] box) // метод заполняет массив
{
  
    int size = array.Length;
    for (int index = 0; index < size; index++)
    {
        box[index] = array[size-1-index];   
    }
}

FillCopyArray(newAr);
Console.WriteLine();
Console.Write("[ ");
PrintArray(newAr);


