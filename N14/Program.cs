﻿//Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23. 

Console.Write("Введите число : ");
int x = Convert.ToInt32(Console.ReadLine());


if (x%26 == 0 && x%7 == 0)
{
    Console.Write($"число {x} кратно одновременно 7 и 26");
}
else{
    Console.Write($"число {x} не кратно одновременно 7 и 26");
}
