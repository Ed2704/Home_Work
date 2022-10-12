/* Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку массива.
 */

Console.Clear();

int[,] array = new int[3, 3];
FillArray(array);
PrintArray(array);
Console.WriteLine();
ReplaceRowArray(array);
PrintArray(array);

void ReplaceRowArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp=array[0,j];
        array[0,j]=array[array.GetLength(0)-1,j];
        array[array.GetLength(0)-1,j] = temp;
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