// Задайте значение M и N.Напишите программу которая выведет все натуральные числа  впромежутке от M до N.
// M=1;N=5->1,2,3,4,5.
using System;
using static System.Console;

Clear();
Write("Введите start: ");
int n = int.Parse(ReadLine());
Write("Введите end: ");
int m = int.Parse(ReadLine());
WriteLine(PrintNumbers(n,m));
String PrintNumbers(int start, int end)
{
    if (end == start)
    {
    Console.WriteLine(end);
    return start.ToString();
}
string s = PrintNumbers(start, end-1)+' '+ end.ToString();

Console.WriteLine(s);
return s;
}