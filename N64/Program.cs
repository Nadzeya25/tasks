// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

void NumberRec(int num)
{
    if (num >= 1)
    {
        Console.WriteLine(num);
        NumberRec(num-1);
    }
}
NumberRec(N);
