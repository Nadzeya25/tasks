/* Задача 13: Напишите программу, которая выводит третью цифру СЛЕВА заданного числа
 или сообщает, что третьей цифры нет. 
645 -> 5 
78 -> третьей цифры нет 
3267912 -> 6 */

int x = -81469799;
int num = Math.Abs(x);//модуль
Console.WriteLine(num);
if (num < 100) Console.WriteLine("Третьей цифры нет");
else
{
    if (num >= 100 && num < 1000)
    {
        Console.WriteLine(num % 10);
    }
    else
    {
        while (num > 999)
        {
            num = num / 10;
        }
        Console.WriteLine(num%10);
    }
}



