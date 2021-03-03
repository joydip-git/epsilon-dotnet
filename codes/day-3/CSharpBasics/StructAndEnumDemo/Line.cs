namespace StructAndEnumDemo
{
    class Line
    {
        Point startPoint;
        Point endPoint;

        public Line()
        {

        }
        public Line(Point start, Point end)
        {
            this.startPoint = start;
            this.endPoint = end;
        }
    }
}