namespace Bridge
{
    public class YellowCircle : IDrawAPI
    {
        public void Draw(int x, int y, int width, int height)
        {
            Console.WriteLine($"The yellow circle was drawn at position ({x},{y}), with radius {width / 2}.");
        }
    }

}

