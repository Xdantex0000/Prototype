using PrototypePattern.Abstractions;

namespace PrototypePattern
{
    class Rectangle : Shape
    {
        private int width;
        private int height;

        public Rectangle(int width, int height, int x, int y)
            : base(x, y)
        {
            this.width = width;
            this.height = height;
        }

        public Rectangle(Rectangle rectangle)
            : base(rectangle)
        {
            width = rectangle.width;
            height = rectangle.height;
        }

        public override string GetDetails()
            => $"Width: {width} Heigth: {height} {base.GetDetails()}";

        public override IPrototype Clone()
            => new Rectangle(this);
    }
}
