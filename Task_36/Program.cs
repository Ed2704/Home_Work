/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Clear();

Console.WriteLine("Введите массив чисел через пробел");
string input = Console.ReadLine()!;
int[] array = ParseToArray(input);


int res = SumOddPositions(array);
Console.WriteLine("Cумма элементов, стоящих на нечётных позициях    " + res);


int SumOddPositions(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i % 2 != 0) sum = sum + arr[i];
    }
    return sum;
}

int[] ParseToArray(string str)
{
    string[] stringArray = str.Split(" ");
    int[] result = new int[stringArray.Length];
 
    for (int i = 0; i < stringArray.Length; i++)
    {
        result[i] = int.Parse(stringArray[i]);
    }
 
    return result;
}