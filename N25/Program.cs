/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B*/

Console.Write("Введите  число A: ");
int  A= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int count = 1;
int rez = A;
while(count < B )
{
    rez = rez * A;
    count++;
}
Console.WriteLine($"число {A} в степени {B} равно {rez}");