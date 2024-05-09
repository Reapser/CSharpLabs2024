using System;

public class Point
{
    private int x;
    private int y;
    private string name;

    public int X => x;
    

    public int Y
    {
        get { return y; }
    }

    public string Name
    {
        get { return name; }
    }

    public Point(int x, int y, string name)
    {
        this.x = x;
        this.y = y;
        this.name = name;
    }
}

public class Figure
{
    private Point[] points;

    public Figure(params Point[] points)
    {
        if (points.Length < 3 || points.Length > 5)
            throw new ArgumentException("Фігура повинна мати від 3 до 5 points.");

        this.points = points;
    }



    private double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

   

    public void PerimeterCalculator()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length; i++)
        {
            int nextIndex = (i + 1) % points.Length;
            perimeter += LengthSide(points[i], points[nextIndex]);
        }
        Console.WriteLine($"Периметр фігури: {perimeter}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Point A = new Point(0, 0, "A");
        Point B = new Point(3, 0, "B");
        Point C = new Point(3, 4, "C");
        Point D = new Point(0, 4, "D");

        
        Figure rectangle = new Figure(A, B, C, D);

        
        rectangle.PerimeterCalculator();
        
    }
}
