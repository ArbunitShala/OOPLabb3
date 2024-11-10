namespace OOPLabb3
{
    public class Circle : Geometry // Ärver från Geometry
    {
        // Egenskap för Circle
        public double Radius { get; set; }

        // Konstruktor för Circle
        public Circle(double radius)
        {
            Radius = radius;
        }
        // Implementerar Area metoden för Circle
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }

}
