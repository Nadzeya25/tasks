/*Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.*/

void FillArray(int[] box) // метод заполняет массив
{
    //  
    int size = box.Length;
    for (int index = 0; index < size; index++)
    {
        box[index] = new Random().Next(100, 1000);    //заполняем числами
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
FillArray(array);  
PrintArray(array);

int Sum4(int[] box)   
{
    int sum = 0;
    int size = box.Length;
    for (int index = 0; index < size; index++)
    {
        if (box[index] %2 == 0)
        {
            sum++;
        }
        
    }
    return sum;
}
int rez = Sum4(array);
Console.WriteLine(rez);





