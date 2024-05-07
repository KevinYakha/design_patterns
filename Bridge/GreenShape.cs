using System;
namespace Bridge
{
    public class GreenShape : IDrawAPI
    {
        public void Draw(string shapeName, int x, int y, int width, int height)
        {
            Console.WriteLine($"The green {shapeName} was drawn at position ({x},{y}), with width {width} and height {height}.");
        }
    }

}

