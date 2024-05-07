namespace Bridge
{
    public class YellowShape : IDrawAPI
    {
        public void Draw(string shapeName, int x, int y, int width, int height)
        {
            Console.WriteLine($"The yellow {shapeName} was drawn at position ({x},{y}), with width {width} and height {height}.");
        }
    }
}
