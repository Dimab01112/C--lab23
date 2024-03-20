using System;

public class Figure
{
    private Point[] points;

    public Figure(Point[] points)
    {
        if (points.Length < 3 || points.Length > 5)
        {
            throw new ArgumentException("A figure must have 3 to 5 points.");
        }

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
            Point currentPoint = points[i];
            Point nextPoint = points[(i + 1) % points.Length];
            perimeter += LengthSide(currentPoint, nextPoint);
        }

        string figureName;
        switch (points.Length)
        {
            case 3:
                figureName = "Triangle";
                break;
            case 4:
                figureName = "Square";
                break;
            case 5:
                figureName = "Pentagon";
                break;
            default:
                figureName = "Unknown Figure";
                break;
        }

        Console.WriteLine($"Name of the figure: {figureName}");
        Console.WriteLine($"Perimeter of the figure: {perimeter}");
    }
}
