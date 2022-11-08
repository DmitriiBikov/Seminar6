// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)




Console.WriteLine("введите значение b1");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("введите число k1");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("введите значение b2");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("введите число k2");
double k2 = Convert.ToDouble(Console.ReadLine());

if (k2-k1 == 0)
{
   Console.WriteLine($"Прямые не пересекаются");
}
else
{
    double pointx = PointX(b1, k1, b2, k2);
    double pointy = PointY(b1, k1, b2, k2);
    Console.WriteLine($"Точка пересечения двух прямых ({pointx} ; {pointy})");
}

double PointX(double meaningb1, double meaningk1, double meaningb2, double meaningk2)
{
double X = Math.Round((meaningb2 - meaningb1) / (meaningk1 - meaningk2), 3);
return X;
}

double PointY(double meaningb1, double meaningk1, double meaningb2, double meaningk2)
{
double Y = Math.Round( meaningk1 * ((meaningb2 - meaningb1) / (meaningk1 - meaningk2)) + meaningb1, 3);
return Y;
}

// double x = (-b2 + b1)/(-k1 + k2);
// double y = k2 * x + b2;

// Console.WriteLine($"Точка пересечения двух прямых в точке с координатами X: {x}, Y: {y}");
