// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int numberM = ReadInt("Введите число M: ");
int numberN = ReadInt("Введите число N: ");

Console.WriteLine(SumBetweenElements(numberM, numberN));


int SumBetweenElements(int m, int n)
{
    if (n > m)
        return n + SumBetweenElements(m, n - 1);
    else if (m > n)
        return m + SumBetweenElements(n, m - 1);
    else
        return m;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
