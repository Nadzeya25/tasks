/*🦀 Задача 26: Напишите программу, которая принимает на вход
 число и выдаёт количество цифр в числе.*/

Console.Write("Введите  число A: ");
int x = Convert.ToInt32(Console.ReadLine());
int A = Math.Abs(x);//модуль
int count = 0;
int i = A;
while ( i > 1 )
{

    i = i/10;                      //если А = 0 ??
        count++;
}

Console.WriteLine(count);

