namespace StructAndEnumDemo
{
    class Wall
    {
        Color wallColor;

        public Wall()
        {

        }
        public Wall(Color color)
        {
            this.wallColor = color;
            System.Console.WriteLine($"Color of my wall is {this.wallColor}");
        }
    }
}