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
/*
Console.Clear();
int[,] matrix = new int[3, 3];
 
Random generator = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = generator.Next(0, 10);
    }
}
 
PrintMatrix(matrix);
Console.WriteLine();
PrintArray(CalcAverage(matrix));
 
 
// Console.Write("Введите индекс строки: ");
// int row = int.Parse(Console.ReadLine()!);
// Console.Write("Введите индекс столбца: ");
// int column = int.Parse(Console.ReadLine()!);
 
// if (IsIndexExists(matrix, row, column))
// {
//     Console.WriteLine(matrix[row, column]);
// }
// else
// {
//     Console.WriteLine("Элемента с таким индексом не существует");
// }
 
double[] CalcAverage(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];
    double sum;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j,i];
        }
        result[i] = sum / matrix.GetLength(0);
    }
    return result;
}
 
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + " ");
    }
}
 
bool IsIndexExists(int[,] matrix, int row, int column)
{
    if (row < matrix.GetLength(0) &&
        column < matrix.GetLength(1) &&
        row >= 0 && column >= 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}