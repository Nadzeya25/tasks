 /*🐞Задача 22: Напишите программу, которая принимает на вход число (N)
  и выдаёт таблицу квадратов чисел от 1 до N. */


  Console.Write("Введите N : ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"{N} => ");
for (int i = 1; i <= N; i++)
{
    
    Console.Write($"{i*i} ");
}
