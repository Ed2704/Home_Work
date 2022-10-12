/* Задача 58: Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц. */

Console.Clear();
int[,] matrix1 = new int[3, 3];
int[,] matrix2 = new int[3, 3];

Console.WriteLine("Даны 2 матрицы:");
FillArray(matrix1);
PrintArray(matrix1);
Console.WriteLine("и");
FillArray(matrix2);
PrintArray(matrix2);
Console.WriteLine();
Console.WriteLine("Их произведение будет равно следующему массиву:");

PrintArray(MatrixProduct(matrix1, matrix2));


int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(0); j++)
        {
            result[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
    return result;
}

void FillArray(int[,] array)
{
    Random generator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = generator.Next(1, 10);
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