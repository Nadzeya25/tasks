// 🙆Задача N1. Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго. 

Console.Write("Введите число x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (y * y == x)
{
    Console.Write($"число {x} является квадратом числа {y}");
}
else{
    Console.Write($"число {x} не является квадратом числа {y}");
}
