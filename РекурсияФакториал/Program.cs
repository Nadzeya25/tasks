// Рекурсия Факториал из лекции 4
// 1 вариант:
// int Factorial(int n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// Console.WriteLine(Factorial(6));            выводит в консоль только факториал числа


// 2 вариант из лекции 4
// int Factorial(int n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }

// for (int i = 1; i < 6; i++)                    // если добавить цикл, то будет выводить 
// {                                               // факториалы всех чисел до заданного числа
//     Console.WriteLine($"{i}! = {Factorial(i)}");

// }

//вариант из семинара
// Console.WriteLine("Введите число > 0 для вычисления факториала: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int Fact(int num)
// {
//     if(num == 1) return 1;
//     else return num * Fact(num-1);
// }
// int x = Fact(n);
// System.Console.WriteLine($"Факториал числа {n} равен {x}");

// интеративный метод вычисления факториала числа (без рекурсии)
int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
  
}

Console.WriteLine(FactorialFor(10));