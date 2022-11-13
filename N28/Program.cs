/* 🐺Задача 28: Напишите программу, которая принимает на вход
 число N и выдаёт произведение чисел от 1 до N.*/


Console.Write("Введите  число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
for (int i = 1; i <= n; i++)
{
  count = count * i;
}
Console.WriteLine(count);


