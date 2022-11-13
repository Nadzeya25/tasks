/*Задача 24: Напишите программу, которая принимает на вход число (А)
 и выдаёт сумму чисел от 1 до А*/

Console.Write("Введите N : ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"{N} => ");
int count = 0;
for (int i = 1; i <= N; i++)
{
    count = count + i; 
}
Console.WriteLine(count);




