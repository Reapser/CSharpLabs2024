using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть довжини сторін трикутника:");

        
        Console.Write("Сторона A: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Сторона B: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Сторона C: ");
        double c = double.Parse(Console.ReadLine());

       
        if (IsValidTriangle(a, b, c))
        {
            
            double perimeter = a + b + c;
            Console.WriteLine($"Периметр трикутника: {perimeter}");

            
            double s = perimeter / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine($"Площа трикутника: {area}");

         
            string triangleType = GetTriangleType(a, b, c);
            Console.WriteLine($"Тип трикутника: {triangleType}");
        }
        else
        {
            Console.WriteLine("Трикутник з такими сторонами не існує.");
        }
    }

    
    static bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }

    
    static string GetTriangleType(double a, double b, double c)
    {
        if (a == b && b == c)
        {
            return "Рівносторонній";
        }
        else if (a == b || b == c || a == c)
        {
            return "Рівнобедрений";
        }
        else
        {
            return "Різносторонній";
        }
    }
}
