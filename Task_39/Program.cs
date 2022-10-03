//Задача 39: Напишите программу, которая перевернет массив


Console.Clear();

Console.WriteLine("Введите числа массива через пробел");
string input = Console.ReadLine()!;
int[] array = ParseToArray(input);


int[] res = TurnOver(array);
PrintArray(res);


int[] TurnOver(int[] arr)
{
    for (int i = 0; i < arr.Length/2; i++)
    {
        int variable = arr [i];
        arr[i] = arr[arr.Length-i-1];
        arr[arr.Length-i-1] = variable;
    }
    return arr;
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
