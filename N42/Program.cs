// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 

// Console.WriteLine("введите десятичное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
int num = 1001;
int res = num;
int count = 0;
while (res >= 1)
{
    res = res / 2;
    count++;
}
System.Console.Write($"{num} => ");
int[] array = new int[count];

void FillArray(int[] box) // метод заполняет массив
{
    int size = box.Length;
    for (int index = size - 1; num >= 1; index--)
    {
        if (num % 2 != 0)
        {
            box[index] = 1;
        }
        else
        {
            box[index] = 0;
        }                                                  // не доделано
        num = num / 2;
    }
}
void PrintArray(int[] box)
{
    int size = box.Length;
    for (int index = 0; index < size; index++)
    {
        Console.Write($"{box[index]} ");
    }
}


FillArray(array);
PrintArray(array);



