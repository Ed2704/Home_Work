Console.Clear();
Console.WriteLine ("Введите первое число: ");
int numberA = int.Parse (Console.ReadLine());

Console.WriteLine ("Введите второе число: ");
int numberB = int.Parse (Console.ReadLine());

if (numberA > numberB)
{
    Console.Write ("Max = " +numberA);
    Console.Write (" Min = " +numberB);
}
else
{
    Console.Write ("Max = " +numberB);
    Console.Write (" Min = " +numberA);
}