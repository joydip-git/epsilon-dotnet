namespace StructAndEnumDemo
{
    struct Point
    {
        private int x_ordinate;
        private int y_ordinate;

        //you can not write a default constructor explicitly
        //you can write parameterized ctor explicitly and that also should assign values to all data members
        // public Point(int xOrdinate)
        // {
        //     this.x_ordinate = xOrdinate;
        //     this.y_ordinate = 0;
        // }
        public Point(int xOrdinate, int yOrdinate)
        {
            this.x_ordinate = xOrdinate;
            this.y_ordinate = yOrdinate;
        }

        public int GetXOrdinate()
        {
            return this.x_ordinate;
        }
        public int GetYOrdinate()
        {
            return this.y_ordinate;
        }
    }
}