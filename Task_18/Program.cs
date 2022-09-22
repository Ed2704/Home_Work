Console.Write("Введите номер координатной четверти: ");
int X = int.Parse(Console.ReadLine()!);

if (X ==1)
{
    Console.WriteLine("Х > 0 и Y > 0");
}

if (X ==2)
{
    Console.WriteLine("Х < 0 и Y > 0");
}

if (X ==3)
{
    Console.WriteLine("Х < 0 и Y < 0");
} 

if (X ==4)
{
    Console.WriteLine("Х > 0 и Y < 0");
}