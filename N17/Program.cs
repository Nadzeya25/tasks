//🐬Задача 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта точка. 
Console.WriteLine("Введите x не равный нулю: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y не равный нулю: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x == 0 || y == 0)
{
   Console.WriteLine("Проверьте вводимые значения");
}
else
{
if( x > 0 && y > 0)Console.WriteLine("Точка находится в 1 четверти");
if( x > 0 && y < 0)Console.WriteLine("Точка находится в 4 четверти");
if( x < 0 && y > 0)Console.WriteLine("Точка находится в 2 четверти");
if( x < 0 && y < 0)Console.WriteLine("Точка находится в 3 четверти");
}
