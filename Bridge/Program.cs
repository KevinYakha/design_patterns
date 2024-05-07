namespace Bridge;

class Program
{
    static void Main(string[] args)
    {
        // Creating a rectangle object using a 'GreenRectangle' drawing method.
        Shape greenRectangle = new Rectangle(new GreenShape(), 100, 200, 32, 32);
        Shape yellowRectangle = new Rectangle(new YellowShape(), 150, 250, 24, 24);

        Shape circle = new Circle(new GreenShape(), 250, 250, 16);

        // Drawing the rectangle.
        greenRectangle.Draw();
        yellowRectangle.Draw();

        circle.Draw();

        // Prevents the console window from closing immediately.
        Console.ReadKey();
    }
}
