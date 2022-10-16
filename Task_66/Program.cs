/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в 
промежутке от M до N. Рекурсивно

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Clear();

Console.Write("Введите два положительных значения через Enter: ");
int m = int.Parse (Console.ReadLine()!);
int n = int.Parse (Console.ReadLine()!);

SumIntegers(m,n);

int SumIntegers(int m, int n)
{
    int sum = 0;
    for (int i = m; i < n; i++)
    {
        
    }
    return sum;
}

