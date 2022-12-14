// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = 1;
int n = 15;
System.Console.WriteLine(SumNaturalElements(m,n));
int SumNaturalElements(int m, int n)
{
    if(n==m)
    return m;
    return SumNaturalElements(m,(n-1))+n;
}
