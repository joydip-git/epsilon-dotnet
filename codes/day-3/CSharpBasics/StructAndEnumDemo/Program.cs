using System;

namespace StructAndEnumDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Color myWallColor = Color.green;
            // Wall myWall = new Wall(myWallColor);

            // Point point;
            // point.x_ordinate = 10;
            // point.y_ordinate = 20;

            //Though default parameterless constructor is not allowed to be written inside the struct explicitly, still CSC supplies the default ctor
            //the following syntax is similar to class object creation, BUT in this case no object is created of struct (Point)
            // Point point = new Point(10, 20);
            // System.Console.WriteLine(point.GetXOrdinate());
            // System.Console.WriteLine(point.GetYOrdinate());

           Line line = Create();
        }
        static Line Create()
        {
            Point start = new Point(10, 10);
            Point end = new Point(100, 100);
            Line line = new Line(start, end);
            return line;
        }
    }
}
