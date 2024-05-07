namespace Bridge;

class Program
{
    static void Main(string[] args)
    {
        // Creating a rectangle object using a 'GreenRectangle' drawing method.
        Shape greenRectangle = new Rectangle(new GreenRectangle(), 100, 200, 32, 32);
        Shape yellowRectangle = new Rectangle(new YellowRectangle(), 150, 250, 24, 24);

        Shape greenCircle = new Circle(new GreenCircle(), 200, 250, 16);
        Shape yellowCircle = new Circle(new YellowCircle(), 200, 200, 12);

        // Drawing the rectangle.
        greenRectangle.Draw();
        yellowRectangle.Draw();

        greenCircle.Draw();
        yellowCircle.Draw();

        // Prevents the console window from closing immediately.
        Console.ReadKey();
    }
}
