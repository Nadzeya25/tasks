// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Введите число m >= 0: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n >= 0: ");
int n = Convert.ToInt32(Console.ReadLine());

  
// int rec(int n, int m)
//        {
//            if (n == 0)
//                return (m + 1);
//            if (m == 0)
//                return rec(n - 1, 1);
//            return rec(n - 1, rec(n, m - 1));
//        }
//  Console.WriteLine(rec(2,3));

//  Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int Ackerman(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     else
//       if ((m != 0) && (n == 0))
//         return Ackerman(m - 1, 1);
//     else
//         return Ackerman(m - 1, Ackerman(m, n - 1));
// }

// Console.WriteLine($"Функция Аккермана для чисел M = {m} и N = {n} равна : {Ackerman(m,n)}");



int Akk(int a, int b)
{
    if (a == 0)
        return b + 1;
    else
      if ((a != 0) && (b == 0))
        return Akk(a - 1, 1);
    else
        return Akk(a - 1, Akk(a, b - 1));
}
Console.WriteLine();
Console.WriteLine($"функция Аккермана равна {Akk(m, n)}"); 

