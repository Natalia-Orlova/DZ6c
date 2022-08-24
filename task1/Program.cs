// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

void PointIntersection(double b11, double k11, double b22, double k22)
{
    if (k11 / k22 == b11 / b22) 
    Console.WriteLine($"При значениях b1={b1}, k1={k1}, b2={b2}, k2={k2} прямые совпадают");
    else if (k11 == k22) 
    Console.WriteLine($"При значениях b1={b1}, k1={k1}, b2={b2}, k2={k2} прямые параллельны и не пересекаются");
    else
    {
        double x = Math.Round((b22 - b11) / (k11 - k22), 2, MidpointRounding.ToZero);
        double y = Math.Round(k11 * x + b11, 2, MidpointRounding.ToZero);
        Console.WriteLine($"При значениях b1={b1}, k1={k1}, b2={b2}, k2={k2} точка пересечения двух прямых: ({x}; {y})");
    }
}

PointIntersection(b1, k1, b2, k2);
