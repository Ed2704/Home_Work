Console.Clear();
Console.WriteLine ("Введите трехзначное число: "!);
int number = int.Parse(Console.ReadLine());

int secondNumber = (number%100 -number%10)/10;

Console.WriteLine("Второе число:  " +secondNumber);