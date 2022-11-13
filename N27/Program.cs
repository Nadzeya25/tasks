/*Задача 27: Напишите программу, которая принимает
 на вход число и выдаёт сумму цифр в числе. */

Console.Write("Введите  число A: ");
int x = Convert.ToInt32(Console.ReadLine());
int A = Math.Abs(x);//модуль
int count = 0;
int i = A;
while (i > 0)
{
    count = i % 10 + count; ;
    i = i / 10;                      //если А = 0 ??

}

Console.WriteLine(count);




