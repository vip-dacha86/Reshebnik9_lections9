// Напишите программу которая принимает на вход 2 числа и возводит число А в целую степень В с помощью рекурсии
// А=3;В=5 ->243()

using System;
using static System.Console;
Clear();
Write("Введите число: ");
int m = int.Parse(ReadLine());
Write("Введите степень числа: ");
int n = int.Parse(ReadLine());
WriteLine($"{Pow(m,n)}");
int res = m;
for (int i = 0; i < n; i++)
{
    m *= res;
}
int Pow(int number,int rank)
{
    if(rank == 0)
    return 1;
    return (number*Pow(number,rank-1));
}
