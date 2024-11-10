namespace OOPLabb3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapar objektreferenser från geometry och sedan av underklasserna
            Geometry square = new Square(4);
            Geometry rectangle = new Rectangle(7, 3.5);
            Geometry circle = new Circle(5);
            
            // Array av alla geometry referenser
            Geometry[] shapes = { square, rectangle, circle };

            // Loopar igenom varje objekt
            foreach(var shape in shapes)
            {
                // Get.Type för att skriva ut namnet och arean för det aktuella objektet
                // Polymorfism används i anropet på Area(), samma anrop på objekten men olika implementationer/uträkningar
                // för att de är av olika typer av objekt
                Console.WriteLine($"Area of {shape.GetType().Name}: " + Math.Round(shape.Area(),2));
            }
        }
    }
}
