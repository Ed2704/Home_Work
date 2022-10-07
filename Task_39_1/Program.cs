/*Console.Clear();
 
int number = int.Parse(Console.ReadLine()!);
 
Console.WriteLine($"Sum: {RecSum(number)}");
 
 
int RecSum(int number)
{
    if (number > 1)
    {
        return number + RecSum(number - 1);
    }
    else
    {
        return 1;
    }
}
*/

/* Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Количество цифр: {CountDigits(number)}");

int CountDigits(int number)
{
    int count = 0;
    if (number / 10 != 0)
    {
        count++;
        return count + CountDigits(number / 10);
    }
    else
    {
        return count + 1;
    }
}
 */

int[] array = {1,2,3,4,5};
RecPrintArray(array);


void RecPrintArray(int[] array, int index =0)
{
    if (index < array.Length)
    {
        Console.WriteLine(array[index]);
        index++;
        RecPrintArray(array, index);

    }
}
