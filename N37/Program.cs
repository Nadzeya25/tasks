

/*Задача 37: Найдите произведение пар чисел в одномерном массиве
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
 Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/
int[] myArray = { 10, 13, -4, 3, 10 };
int sizeAr = myArray.Length;
int[] CopyAr = new int[sizeAr / 2 + sizeAr % 2];

void FillArray(int[] box) 
{
    int size = sizeAr / 2 + sizeAr % 2;
    for (int index = 0; index < size; index++)
    {
        if (sizeAr % 2 != 0 && index == sizeAr - 1 - index)
        {
            box[index] = myArray[sizeAr - 1 - index];
        }
        else
        {
            box[index] = myArray[index] * myArray[sizeAr - 1 - index];
        }
       
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
Console.Write("[ ");
PrintArray(myArray);
Console.Write("]");

Console.WriteLine();


FillArray(CopyAr);
Console.Write("[ ");
PrintArray(CopyAr);
Console.Write("]");