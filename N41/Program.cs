/*Задача 41: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.*/
Console.WriteLine("Какое количество чисел нужно проверить? ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[m];
void FillArray(int[] box) // метод заполняет массив
{
    int count = 0;
    int size = box.Length;
    for (int index = 0; index < size; index++)
    {
        Console.WriteLine($"Введите {index + 1} число: ");
        box[index] = Convert.ToInt32(Console.ReadLine());
        if (box[index] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество положительных чисел в данной последовательности равна {count}");
}
void PrintArray(int[] box)   // метод печатает
{
    Console.Write("[ ");
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


FillArray(massiv);   //заполняет массив 
PrintArray(massiv);
