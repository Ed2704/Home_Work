/* Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке 
от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Clear();

Console.Write("Введите число болше 1: ");
int x = int.Parse (Console.ReadLine()!);
Integers(x);

void Integers(int n)
{
    for (int i = n; i > 0; i--)
    {
        if(i>1) Console.Write($"{i}, ");
        else Console.Write($"{i}");
    }
}
