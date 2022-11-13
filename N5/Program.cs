// Задача N5. Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N. 

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    int res = -num;
    while (res <= num && res >= -num)
    {
        Console.Write($"{res} ");
        res++;
    }
}
else
{
int res = num;
    while (res >= num && res <= -num)
    {
        Console.Write($"{res} ");
        res++;
    }
}

