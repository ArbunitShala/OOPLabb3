namespace OOPLabb3
{
    public class Square : Geometry // Ärver från Geometry
    {
        // Egenskap för Square
        public double Side{ get; set; }

        // Konstruktor för Square
        public Square(double side)
        {
            Side = side;
        }
        // Implementerar Area metoden för Square
        public override double Area()
        {
            return Side * Side;
        }
    }
}
