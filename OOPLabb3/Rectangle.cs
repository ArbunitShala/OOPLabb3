namespace OOPLabb3
{
    public class Rectangle : Geometry // Ärver från Geometry klassen
    {
        // Egenskaper för Rectangle
        public double Height { get; set; }
        public double Width { get; set; }

        // Konstruktor för Rectangle
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
        // Implementerar Area metoden för Rectangle
        public override double Area()
        {
            return Height * Width;
        }
    }
}
