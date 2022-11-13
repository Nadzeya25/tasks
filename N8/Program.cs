// Задача 8: Напишите программу, которая на вход принимает число (N)
//, а на выходе показывает все чётные числа от 1 до N. 


Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
{
    num = -num;

    for (int res = 0; res <= num; res = res + 2)
    {
        Console.WriteLine(-res);
    }
}
else
{
for (int res = 2; res <= num; res = res + 2)
    {
        Console.WriteLine(res);
    }
}


