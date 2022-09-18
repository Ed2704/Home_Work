Console.Clear();
Console.WriteLine ("Введите первое число: ");
string input = Console.ReadLine();
int numberA = int.Parse (input);

Console.WriteLine ("Введите второе число: ");
string input1 = Console.ReadLine();
int numberB = int.Parse (input1);

Console.WriteLine ("Введите третье число: ");
string input2 = Console.ReadLine();
int numberC = int.Parse (input2);

int max = 0;

if (numberA > numberB)
{
    max = numberA;
}
else
{
    max = numberB;
}

if (numberC > max)
{
    max = numberC;
}

Console.WriteLine ("Максимальное число: ");
Console.Write (max);