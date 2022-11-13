/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.*/
void FillArray(double[] box) // метод заполняет массив
{
    //  
    int size = box.Length;
    for (int index = 0; index < size; index++)
    {
        box[index] = new Random().NextDouble();    //заполняем числами от 1 до 9
    }
}
void PrintArray(double[] box)   // метод печатает
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
double[] array = new double[4]; // 4 количество элементов - размер массива
FillArray(array);   //заполняет массив 
PrintArray(array);
Console.WriteLine();
double Max(double[] box)
{
    double max = box[0];
    for (int i = 0; i < box.Length; i++)
    {
        
        if (box[i] >max)
        {
            max = box[i];
        }
    }
   return max;
    
}
Console.WriteLine();
Max(array);
double Min(double[] box)
{
    double min = box[0];
    for (int i = 0; i < box.Length; i++)
    {
        
        if (box[i] < min)
        {
            min = box[i];
        }
    }
    return min;
    
}
Console.WriteLine();

double nummax = Max(array);
double nummin = Min(array);
Console.WriteLine(nummax);
Console.WriteLine(nummin);
Console.WriteLine(nummax- nummin);
