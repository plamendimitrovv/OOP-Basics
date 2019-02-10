using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {

        string[] inputToken = Console.ReadLine().Split();
        int numRec = int.Parse(inputToken[0]);
        int numIntersect = int.Parse(inputToken[1]);
        var rectangles = new List<Rectangle>();
       

        for (int i = 0; i < numRec; i++)
        {
            string[] RectanglesToken = Console.ReadLine().Split();
            string id = RectanglesToken[0];
            int width = int.Parse(RectanglesToken[1]);
            int height = int.Parse(RectanglesToken[2]);
            int coordinateX = int.Parse(RectanglesToken[3]);
            int coordinateY = int.Parse(RectanglesToken[4]);

            var rectangle = new Rectangle(id, width, height, coordinateX, coordinateY);
            rectangles.Add(rectangle);
        }

        for (int i = 0; i < numIntersect; i++)
        {
            string[] pairs = Console.ReadLine().Split();
            var firstRec = rectangles.FirstOrDefault(r => r.Id == pairs[0]);
            var secondRec = rectangles.FirstOrDefault(r => r.Id == pairs[1]);
            
            Console.WriteLine(firstRec.IntersectsRectangle(secondRec) ? "true" : "false");
        }


    }
}
