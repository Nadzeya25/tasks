// Задача 63: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от 1 до N.

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int m = 1;
void NumberRec(int a, int b)         
{
    if (a <= b)
    {
        Console.WriteLine(a);
        NumberRec(a + 1, b);
    }
}
NumberRec(m, n);




////////////////////////////////////////////////////////////////////




