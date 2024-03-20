using System;

public class Point
{
    private int x;
    private int y;
    private string label;

    public int X
    {
        get { return x; }
    }

    public int Y
    {
        get { return y; }
    }

    public string Label
    {
        get { return label; }
    }

    public Point(int x, int y, string label)
    {
        this.x = x;
        this.y = y;
        this.label = label;
    }
}
