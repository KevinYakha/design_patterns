namespace Bridge
{
    public class GreenCircle : IDrawAPI
    {
        public void Draw(int x, int y, int width, int height)
        {
            Console.WriteLine($"The green circle was drawn at position ({x},{y}), with radius {width / 2}.");
        }
    }

}

