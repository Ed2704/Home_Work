/* Задача 44: Напишите программу, которая принимает на вход 2 числа,
количество строк и количество столбцов, создаёт матрицу
данного размера и заполняет нулями или единицами в случайном порядке
и выводит в консоль.
 */

Console.Clear();
Console.WriteLine("Введите число строк матрицы: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов матрицы: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] arr= CreateArray(rows,columns);
FillArray(arr);
PrintArray(arr);


int [,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    return array;
}

void FillArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i,j] = new Random().Next(0,2);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int rows = 0; rows < arr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < arr.GetLength(1); columns++)
        {
            Console.Write($"|{arr[rows,columns]}|");
        }
        Console.WriteLine();
    }
}