/*Задача 32: Напишите программу замена элементов массива:
 положительные элементы замените на соответствующие отрицательные, и наоборот.*/

void FillArray(int[] box) // метод заполняет массив
{
    //  
    int size = box.Length;
    for (int index = 0; index < size; index++)
    {
        box[index] = new Random().Next(-8, 20);    //заполняем числами от -8 до 19
    }
}
void PrintArray(int[] box)  
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
Console.WriteLine();

void CoverArray(int[] box)  
{
    int size = box.Length;
    for (int index = 0; index < size; index++)
    {
        if (index == size - 1)
        {
            Console.Write($"{-box[index]} ]");
        }
        else
        {
            Console.Write($"{-box[index]}, ");
        }
    }
}
Console.Write("[ ");
CoverArray(array);


