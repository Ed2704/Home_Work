/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в 
промежутке от M до N. Рекурсивно

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Clear();

Console.WriteLine("Введите 2 положительных числа M и N через Enter:");
int m = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);
int temp = m;
if (m > n)
{
    m = n;
    n = temp;
}

Console.Write($"Сумма в промежутке между {m} и {n} равна: {SumIntegers(m, n)}");

int SumIntegers(int m, int n)
{
    int sum = 0;

    if (n >= m)
    {
        sum = n + SumIntegers(m, n - 1);
    }
    return sum;
}