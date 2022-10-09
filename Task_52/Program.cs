/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 */

Console.Clear();

int[,] array = new int[3, 4];
FillArray(array);
Console.WriteLine("Задан двумерный массив:");
PrintArray(array);
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца:  ");


for (int j = 0; j < array.GetLength(1); j++)
{
    double sumColumn = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sumColumn = sumColumn + array[i,j]; 
    }
    double averege = sumColumn / array.GetLength(0); 
    Console.Write("{0:0.0}  ", averege);
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