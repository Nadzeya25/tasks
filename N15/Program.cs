﻿//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным. 

Console.Write("Введите номер дня недели : ");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 1 || x > 7)
{
    Console.WriteLine("Проверьте номер, который вводите");
}
else
{
    if (x == 6 || x == 7)
    {
        Console.WriteLine("Этот день - выходной");

    }
    else
    {
        Console.WriteLine("Это будний день");
    }

}
