/* Задача 43: Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2;
 значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 */

Console.Clear();
Console.WriteLine("Введите b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b2: ");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k2: ");
double k2 = double.Parse(Console.ReadLine()!);

double[] point = IntersectionLine(b1, k1, b2, k2);
Console.WriteLine(point[0] + " " + point[1]);

double[] IntersectionLine(double b1, double k1, double b2, double k2)
{
    double[] res = new double[2];
    res[0] = (b2 - b1) / (k1 - k2);
    res[1] = k1 * (b2 - b1) / (k1 - k2) + b1;
    return res;
}