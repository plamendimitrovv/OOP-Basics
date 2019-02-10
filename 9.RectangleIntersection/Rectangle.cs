using System;
using System.Collections.Generic;
using System.Text;


public class Rectangle
{
    private string id;
    private int width;
    private int height;
    private int horizontal;
    private int vertical;

    public Rectangle(string id, int width, int height, int horizontal, int vertical)
    {
        this.id = id;
        this.width = width;
        this.height = height;
        this.horizontal = horizontal;
        this.vertical = vertical;
    }

    public string Id
    {
        get { return this.id; }
        set { this.id = value; }
    }

    public int Width
    {
        get { return this.width; }
        set { this.width = value; }
    }

    public int Height
    {
        get { return this.height; }
        set { this.height = value; }
    }

    public int Horizontal
    {
        get { return this.horizontal; }
        set { this.horizontal = value; }
    }

    public int Vertical
    {
        get { return this.vertical; }
        set { this.vertical = value; }
    }

    public bool IntersectsRectangle(Rectangle r)
    {
        return this.ContainsRecCorner(r) || r.ContainsRecCorner(this);
    }


    private bool ContainsRecCorner(Rectangle r)
    {
        return this.ContainsPoint(r.horizontal, r.vertical) ||
               this.ContainsPoint(r.horizontal, r.vertical + height) ||
               this.ContainsPoint(r.horizontal + width, r.vertical) ||
               this.ContainsPoint(r.horizontal + width, r.vertical + height);
    }

    private bool ContainsPoint(double x, double y)
    {
        return x >= this.horizontal
            && x <= this.horizontal + width
            && y >= this.vertical
            && y <= this.vertical + height;
    }
}
