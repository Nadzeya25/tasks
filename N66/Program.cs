// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m > n)
{
    int temp = m;
    m = n;
    n = temp;
}
int SumRec(int a, int b)
{
    if(a == b) return a;
    else return a + SumRec(a + 1, b);
}
Console.WriteLine(SumRec(m, n));
