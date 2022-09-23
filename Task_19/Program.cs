Console.Clear();
Console.WriteLine ("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);

if (number < 10000 || number > 100000)
{
    Console.WriteLine ("Вы ввели число неправильно");
}
else
{
    int num1 = number / 10000;
    int num2 = number % 10000 /1000;
    int num4 = number % 100 / 10;
    int num5 = number % 10;

    if(num1 ==num5 && num2 == num4) Console.WriteLine ("Да, это палиндром");
    else Console.WriteLine ("Нет, это не палиндром");
}