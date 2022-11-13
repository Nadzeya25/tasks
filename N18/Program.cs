/*  🐽Задача 18: Напишите программу, которая по заданному номеру четверти,
 показывает диапазон возможных координат точек в этой четверти (x и y).*/ 
 


Console.WriteLine("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());
if(quarter < 1 || quarter > 4 )
{
    Console.WriteLine("Проверьте значение , которое вводите");
}
else
{
if( quarter == 1)Console.WriteLine($" В данной четверти x > 0, y > 0");
if( quarter == 2)Console.WriteLine($" В данной четверти x < 0, y > 0");
if( quarter == 3)Console.WriteLine($" В данной четверти x < 0, y < 0");
if( quarter == 4)Console.WriteLine($" В данной четверти x > 0, y < 0");
}