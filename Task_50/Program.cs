/* Задача 50. Напишите программу, которая на вход 
принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание,
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1
7 -> такого числа в массиве нет */

Console.Clear();


int[,] array = new int[3, 5];
FillArray(array);
Console.WriteLine("Задан двумерный массив:");
PrintArray(array);

Console.WriteLine("Введите адрес элемента массива через Enter: ");
int i = int.Parse(Console.ReadLine()!);
int j = int.Parse(Console.ReadLine()!);

if(i<array.GetLength(0) && j<array.GetLength(1))
{
    Console.WriteLine($"Значение элемента массива [{i} ,{j}]:  {array[i,j]}");
}
else
{
    Console.WriteLine("Такого элемента нет!");
}

void FillArray(int[,] array)
{
    Random generator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = generator.Next(1,10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}