/* 🐰**Задача 16:**  
Напишите программу, которая принимает на вход два числа и проверяет,
 является ли одно число квадратом другого.*/ 

Console.Write("Введите первое число : ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число : ");
int x2 = Convert.ToInt32(Console.ReadLine());

if ( x1 == x2*x2 ) Console.WriteLine($"число {x1} является квадратом {x2}");
else Console.WriteLine($"число {x1} не является квадратом {x2}");
if ( x2 == x1*x1 ) Console.WriteLine($"число {x2} является квадратом {x1}");
else Console.WriteLine($"число {x2} не является квадратом {x1}");
