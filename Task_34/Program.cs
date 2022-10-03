/*Задача 34: Задайте массив заполненный случайными положительными
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Console.Clear();

Console.WriteLine("Введите массив из трехзначных чисел через пробел");
string input = Console.ReadLine()!;
int[] array = ParseToArray(input);


int res = НonestNumbers(array);
Console.WriteLine("Количество четных чисел в массиве - " + res);


int НonestNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0) count++;
    }
    return count;
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