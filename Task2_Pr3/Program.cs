using System;


class Program
{
    static void Main(string[] args)
    {
        Point[] points = new Point[]
        {
            new Point(0, 0, "A"),
            new Point(0, 3, "B"),
            new Point(4, 0, "C"),
            new Point(8, 0, "D"),

        };

        Figure figure = new Figure(points);
        figure.PerimeterCalculator();
    }
}
