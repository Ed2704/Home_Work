/*Задача 37: Напишите метод, который объединяет 2 массива в 1. 
[5, 18, 123, 6, 2] + [1, 2, 3] = [5, 18, 123, 6, 2, 1, 2, 3]
*/

Console.Clear();

Console.WriteLine("Введите числа первого массива через пробел");
string input1 = Console.ReadLine()!;
Console.WriteLine("Введите числа второго массива через пробел");
string input2 = Console.ReadLine()!;

int[] array1 = ParseToArray(input1);
int[] array2 = ParseToArray(input2);


int[] res = Unite2in1(array1, array2);
PrintArray(res);


int[] Unite2in1(int[] firstarray, int[] secondarray)
{
    int[] arraySum = new int[firstarray.Length + secondarray.Length];
    for (int i = 0; i < firstarray.Length; i++)
    {
        arraySum[i] = firstarray[i];

    }
    for (int i = 0; i< secondarray.Length; i++)
    {
        arraySum[i+firstarray.Length] = secondarray[i];
    }
    return arraySum;
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

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i]);
        if (i == count - 1)
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
}