/* Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов. */

Console.Clear();
int[,] matrix = new int[4, 4];
Console.WriteLine("Задан массив:");
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов - {StringMinSumElements(matrix)}");


int StringMinSumElements(int[,] matrix)
{
    int iMin = 0;
    int minSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (sum < minSum || i == 0)
        {
            minSum = sum;
            iMin = i + 1;
        }
    }
    return iMin;
}

void FillArray(int[,] array)
{
    Random generator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = generator.Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
