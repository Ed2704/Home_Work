Console.Clear();
Console.WriteLine ("Введите число: ");
int number = int.Parse(Console.ReadLine());

if ((Math.Abs(number) % 2) > 0 )
{
    Console.WriteLine ("Нет");
}
else
{
    Console.WriteLine ("Да");
}