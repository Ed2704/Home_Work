Console.Clear();

Console.Write("Введите число болше 1: ");
int x = int.Parse (Console.ReadLine()!);
int i = 1;

while (i <= x)
{
  int result = (int) Math.Pow ( i, 3);
    if (i != x)
    {
        Console.Write (result + ", ");
    }
    else
    {  
        Console.Write (result);
    }
  i++;
}