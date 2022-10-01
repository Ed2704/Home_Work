/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр 
в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();
Console.WriteLine ("Введите число: "!);
int a = int.Parse(Console.ReadLine());
int sum =Sum(a);
Console.WriteLine(sum);

int Sum (int a)
{
    int signsNumbers =a;
    int i=0;
    
    while(signsNumbers > 0) 
    {
        i++;
        signsNumbers/= 10;
    }
    
    int sum=0;
    for(int j=0; j<i; j++)
    {
        int pov1= (int)Math.Pow(10, j+1);
        int pov2= (int)Math.Pow(10, j);
        int res=(a%pov1 - a%pov2)/pov2;
        sum=sum+res;
    }
    return sum;
}