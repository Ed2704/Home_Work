/* Задача 41: Пользователь вводит с клавиатуры число M,
потом вводит M чисел ЧЕРЕЗ ENTER. Посчитайте, сколько
 чисел больше 0 ввёл пользователь. */

Console.Clear();
Console.WriteLine("Введите число: ");
int countDigit = int.Parse(Console.ReadLine()!);
Console.WriteLine($"А теперь вводите {countDigit} чисел через Enter");

int count=0;
for (int i = 0; i < countDigit; i++)
{
    int currentDigit=int.Parse(Console.ReadLine()!);
    if (currentDigit>0) count++;
}
Console.WriteLine($"Введено положительных чисел: {count}");