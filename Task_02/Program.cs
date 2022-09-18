Console.Clear();
Console.WriteLine ("Введите первое число: ");
int numberA = int.Parse (Console.ReadLine());

Console.WriteLine ("Введите второе число: ");
int numberB = int.Parse (Console.ReadLine());

if (numberA > numberB)
{
    Console.Write ("Max = ");
    Console.Write (numberA);
    Console.Write (" Min = ");
    Console.Write (numberB);

}
else
{
    Console.Write ("Max = ");
    Console.Write (numberB);
    Console.Write (" Min = ");
    Console.Write (numberA);
}