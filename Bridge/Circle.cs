namespace Bridge
{
    public class Circle : Shape
    {
        private int x;
        private int y;
        private int radius;

        public Circle(IDrawAPI drawAPI, int x, int y, int radius)
            : base(drawAPI)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void Draw()
        {
            drawAPI.Draw(x, y, radius * 2, radius * 2);
        }
    }
}
