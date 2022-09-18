Console.Clear();
Console.WriteLine ("Введите число больше 1: ");
int number = int.Parse(Console.ReadLine());
int count =1;

while (count <= number)
{
    if ((count % 2) == 0)
    {
        Console.Write (count +", ");
        count++;
    }
    count++;
}