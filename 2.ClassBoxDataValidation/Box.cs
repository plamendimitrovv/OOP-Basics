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
        private set
        {
            if (value <= 0)
            {
                throw new Exception("Length cannot be zero or negative.");
            }
            else
            {
                length = value;
            }
        }

    }

    public double Width
    {
        get { return width; }
        private set
        {
            if (value <= 0)
            {
                throw new Exception("Width cannot be zero or negative.");
            }
            else
            {
                width = value;
            }
            
        }
    }

    public double Height
    {
        get { return height; }
        private set
        {
            if (value <= 0)
            {
                throw new Exception("Height cannot be zero or negative.");
            }
            else
            {
                height = value;
            }
        }
    }


    public Box(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }

    public double SurfaceArea()
    {
        var surfaceArea = (2 * length * width)
            + (2 * length * height)
            + (2 * width * height);
        return surfaceArea;
    }

    public double LateralSurfaceArea()
    {
        var lateralSurfaceArea = (2 * length * height)
                               + (2 * width * height);
        return lateralSurfaceArea;
    }

    public double Volume()
    {
        var volume = length * width * height;
        return volume;
    }

}
