Console.Clear();

Console.Write("Введите координату X первой точки ");
double x0 = double.Parse (Console.ReadLine()!);
Console.Write("Введите координату Y первой точки ");
double y0 = double.Parse (Console.ReadLine()!);
Console.Write("Введите координату Z первой точки ");
double z0 = double.Parse (Console.ReadLine()!);

Console.Write("Введите координату X второй точки ");
double x1 = double.Parse (Console.ReadLine()!);
Console.Write("Введите координату Y второй точки ");
double y1 = double.Parse (Console.ReadLine()!);
Console.Write("Введите координату Z второй точки ");
double z1 = double.Parse (Console.ReadLine()!);

double result = Math.Sqrt (Math.Pow (x1-x0,2) + 
                Math.Pow (y1-y0,2) + 
                Math.Pow (z1-z0,2));

Console.WriteLine ("{0:0.00}", result);