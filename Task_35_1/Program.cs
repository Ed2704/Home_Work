/*Задача 35: Напишите метод, который суммирует 2 массива. Каждый
элемент одного массива должен суммироваться с соответствующим 
элементом из второго массива. Если длины массивов не равны, 
то должно появляться сообщение об ошибке

[5, 18, 123, 6, 2] + [1, 2, 3, 6, 2] = [6, 20, 126, 12, 4]
*/
Console.Clear();

Console.WriteLine("Введите числа первого массива через пробел");
string input1 = Console.ReadLine()!;
int[] array1 = ParseToArray(input1);

Console.WriteLine("Введите числа второго массива через пробел");
string input2 = Console.ReadLine()!;
int[] array2 = ParseToArray(input2);

if(array1.Length != array2.Length)
{
    Console.WriteLine("Введены массивы разного размера!!!");
}
else
{
    int[] res = SumArray(array1, array2);
    PrintArray(res);
}

 int[] SumArray(int[] firstarray, int[] secondarray)
{
    int[] arraySum = new int[firstarray.Length];
    for (int i = 0; i < firstarray.Length; i++)
    {
        arraySum[i] = firstarray[i] + secondarray[i];
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