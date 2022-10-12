/* Задача 57: Составить частотный словарь элементов 
двумерного массива. Частотный словарь содержит 
информацию о том, сколько раз встречается элемент 
входных данных.
 */

 int[,] matrix = new int[5, 5];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
CalculatorElements(matrix);

void CalculatorElements(int[,] array)
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