/*Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
 может ли существовать треугольник с сторонами такой длины. 
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон*/
Console.WriteLine("Введите значение 1: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение 2: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение 3: ");
int C = Convert.ToInt32(Console.ReadLine());

if (A + B < C || B + C < A || A + C < B)
{
    Console.WriteLine("треугольник с такими сторонами не существует");

}
else
{
    Console.WriteLine("треугольник с такими сторонами может существовать");
}


