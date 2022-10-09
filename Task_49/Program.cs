/* Задача 49: Задайте двумерный массив. Найдите элементы,
у которых оба индекса чётные, и замените эти элементы 
на их квадраты. */

Console.Clear();

int[,] array = new int[5, 5];

FillArray(array);
PrintArray(array);
Console.WriteLine();
ChengeArrai(array);
PrintArray(array);


void ChengeArrai(int[,] array)
{
    for (int i = 2; i < array.GetLength(0); i+=2)
    {
        for (int j = 2; j < array.GetLength(1); j+=2)
        {
           array[i,j] = (int)Math.Pow(array[i,j],2);
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