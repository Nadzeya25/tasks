// Задача 45: Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования. 
Console.WriteLine("Ведите размер массива:");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
void FillArray(int[] box)
{
    int size = box.Length;

    for (int i = 0; i < size; i++)
    {
        box[i] = new Random().Next(-5, 10);
    }
}

void PrintArray(int[] box)
{
    int size = box.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{box[i]} ");
    }
}
FillArray(array);
PrintArray(array);
Console.WriteLine();
int[] copyArray = new int[array.Length];

void CopyArray(int[] box)
{
    int size = array.Length;

    for (int i = 0; i < length; i++)
    {

        box[i] = array[i];
    }


}

CopyArray(copyArray);
PrintArray(copyArray);