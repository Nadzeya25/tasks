/* Задача 20 Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 2D пространстве.*/

Console.Write("Введите координаты первой точки по оси x: ");
int  x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты первой точки по оси y: ");
int  y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты второй точки по оси x: ");
int  x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты второй точки по оси y: ");
int  y2 = Convert.ToInt32(Console.ReadLine());

double distanc = Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2));


Console.WriteLine(distanc);


