using PrototypePattern.Abstractions;

namespace PrototypePattern
{
    class Circle : Shape
    {
        int radius;

        public Circle(int radius, int x, int y)
            : base(x, y)
        {
            this.radius = radius;
        }

        public Circle(Circle circle)
            : base(circle)
        {
            radius = circle.radius;
        }

        public override string GetDetails()
            => $"Radius: {radius} {base.GetDetails()}";

        public override IPrototype Clone()
            => new Circle(this);
    }
}
