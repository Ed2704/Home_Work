/* Задача 55: Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для пользователя.
 */

 Console.Clear();

int[,] matrix = new int[5, 5];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
if (matrix.GetLength(0) == matrix.GetLength(1))
{
    ReplaceRowsColsArray(matrix);
    PrintArray(matrix);
}
else
{
    Console.WriteLine("Массив не является равносторонним");
}

void ReplaceRowsColsArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            int temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
    }
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