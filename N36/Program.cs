/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.*/

void FillArray(int[] box) // метод заполняет массив
{
    //  
    int size = box.Length;
    for (int index = 0; index < size; index++)
    {
        box[index] = new Random().Next(-20, 20);    //заполняем числами 
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
int[] array = new int[12]; //  количество элементов - размер массива
FillArray(array);   //заполняет массив 
PrintArray(array);

int SumInt(int[] box)   
{
    int count = 0;
    int size = box.Length;
    for (int index = 0; index < size; index++)
    {
        if (index%2 != 0)
        {
            count = count + box[index];
        }
        
    }
   return count; 
}

Console.WriteLine();
int rez = SumInt(array);
Console.WriteLine(rez);






