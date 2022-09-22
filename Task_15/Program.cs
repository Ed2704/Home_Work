Console.Clear();
Console.WriteLine ("Введите число от 1-7");
int number = int.Parse(Console.ReadLine());

if (number > 0 && number < 8)
{
    if (number == 6 || number ==7)
    {
        Console.WriteLine ("Ура!!! Это выходной!");
    }
    else
    {
        Console.WriteLine ("Увы ... Это будни...");
    }
}
else
{
    Console.WriteLine ("Вы неправильно ввели число");
}