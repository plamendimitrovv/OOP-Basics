using System;
using System.Collections.Generic;
using System.Text;


class Box
{
    private double length;
    private double width;
    private double height;

    public double Length
    {
        get { return length; }
        set { length = value; }
    }
    
    public double Width
    {
        get { return width; }
        set { width = value; }
    }

    public double Height
    {
        get { return height; }
        set { height = value; }
    }


    public Box(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }

    public double SurfaceArea()
    {
        var surfaceArea = (2*length*width)
            + (2*length*height) 
            + (2*width*height);
        return surfaceArea;
    }

    public double LateralSurfaceArea()
    {
        var lateralSurfaceArea = (2 * length * height)
                               + (2 * width * height);
        return lateralSurfaceArea;
    }

    public double Volume ()
    {
        var volume = length * width * height;
        return volume; 
    }

}
