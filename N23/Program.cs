﻿/*Задача 23 
Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу кубов чисел от 1 до N. */

Console.Write("Введите N : ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"{N} => ");
for (int i = 1; i <= N; i++)
{
    
    Console.Write($"{Math.Pow(i,3)} ");
}

