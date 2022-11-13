//задача 44. Не используя рекурсию, выведите первые N чисел Фибоначчи 
Console.WriteLine();
Console.Write("Введите, какое количество чисел из последовательности Фибоначчи нужно вывести : ");
int N = Convert.ToInt32(Console.ReadLine());

int res = 0;
int count = 1;
int i = 0;

while (i < N/2)
{
    Console.Write($"{res} ");
    count = count + res;
    res = count + res;
    Console.Write($"{count} ");
    i++;

}

Console.WriteLine();
