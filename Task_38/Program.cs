/*Задача 38: Задайте массив вещественных чисел. Найдите разницу
между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

Console.Clear();

Console.WriteLine("Введите массив чисел через пробел");
string input = Console.ReadLine()!;
double[] array = ParseToArray(input);


double res = DiffMaxMin(array);
Console.Write("Разница между максимальным и минимальным элементов массива  ");
Console.Write ("{0:0.00}", res);

double DiffMaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    double diff= 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
        else if (arr[i] < min) min = arr[i];
    }
    diff = max - min;
    return diff;
}

    double[] ParseToArray(string str)
    {
        string[] stringArray = str.Split(" ");
        double[] result = new double[stringArray.Length];
    
        for (int i = 0; i < stringArray.Length; i++)
        {
            result[i] = double.Parse(stringArray[i]);
        }
    
        return result;
    }
