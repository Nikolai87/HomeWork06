// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. 

double k1 = ReadInt("k1");
double k2 = ReadInt("k2");
double b1 = ReadInt("b1");
double b2 = ReadInt("b2");

Intersection(k1, k2, b1, b2);

double ReadInt(string argument)
{
	Console.Write($"введите {argument}: ");
	return double.Parse(Console.ReadLine()!);
}

void Intersection(double k1, double k2, double b1, double b2)
{
    if (k1 != k2 && b1 != b2)
    {
        double x = 0;
        double y = 0;
        x =(b2 - b1)/(k1 - k2);
        y = k1 * x + b1;
        Console.WriteLine($"точка пересечения A:({x}; {y})");
    }
     
    else if (k1 == k2)
    {
        Console.WriteLine("линии не пересекаются");
    }
}




