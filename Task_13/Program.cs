Console.Clear();
Console.WriteLine ("Введите число, не менее 3-х знаков: ");
int number = int.Parse(Console.ReadLine());
int signsNumbers = number;
int i = 0;

if (number < 100)
{
    Console.WriteLine ("Третьей цифры нет !!!");
}
else
{
while(signsNumbers > 0) 
    {
        i++;
        signsNumbers/= 10;
    }
//Console.WriteLine("Количество знаков введенного числа : {0}", i);

int pov1= (int)Math.Pow(10,(i-2));
int pov2= (int)Math.Pow(10,(i-3));

int secondNumber = (number % pov1 - number % pov2) / pov2;

Console.WriteLine(secondNumber);
}