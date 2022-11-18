//https://gb.ru/lessons/261875#s1536 лекция 7

// собрать строку из чисел от a до b, a>=b

// string NumbersFor(int a, int b)               //1 способ интеративный
// {
//     string result = string.Empty;
//     for (int i = a; i <= b; i++)
//     {
//       result += $"{i} ";  
//     }
//     return result;
// }
// Console.WriteLine(NumbersFor(1, 10));

// string NumberRec(int a, int b)          //2 способ рекурсивный
// {
//     if(a<= b)return $"{a} " + NumberRec(a + 1, b);
//     else return string.Empty;
// }

// Console.WriteLine(NumberRec(1, 10));
//5555555555555555555555555555555555555555555555555555555555555555555555555555555555555555555555555555555555555
//сумма чисел от 1 до n

int SumFor(int n)
{
    int result = 0;                                   //1 способ интеративный
    for(int i = 1; i<= n; i++) result += i;
    return result;
}
Console.WriteLine(SumFor(3));


int SumRec(int n)
{
    if(n == 0) return 0;                                  //2 способ рекурсивный
    else return n + SumRec(n-1);
}
Console.WriteLine(SumRec(3));
// ;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
//возведение в степень числа с рекурсией

// int PowerFor(int a, int b)
// {
//     int result = 1;
//     for (int i = 0; i <= b; i++)
//     {                                  // 1 способ интеративный
//         result *= A;
//     }
//     return result;
// }
// Console.WriteLine(PowerFor(2, 10));

int PowerRec(int a, int n)               // 2 способ с рекурсией
{
    if (n == 0) return 1;  //return n == 0 ? 1 : PowerRec(a, n - 1) * a;  вариант оформления вместо if - else
    else return PowerRec(a, n - 1) * a;

}
Console.WriteLine(PowerRec(2, 10));



