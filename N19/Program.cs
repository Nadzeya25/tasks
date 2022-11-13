/* Задача 19 
Напишите программу, которая принимает на вход пятизначное число
 и проверяет, является ли оно палиндромом. */
Console.Write("Введите пятизначное число : ");
int num = Convert.ToInt32(Console.ReadLine());
int x = Math.Abs(num);   //модуль
int a1 = x / 10000;
int a2 = x / 1000 % 10;
int a4 = x / 10 % 10;
int a5 = x % 10;
// Console.WriteLine(a1);
// Console.WriteLine(a2);
// Console.WriteLine(a4);
// Console.WriteLine(a5);
if (x > 99999 || x < 10000) Console.WriteLine("проверьте число, которое вводите");
else
{
    if (a1 != a5 || a2 != a4) Console.WriteLine($"число {num} не является палиндромом");
    else
    {
        Console.WriteLine($"число {num} является палиндромом");
    }
}