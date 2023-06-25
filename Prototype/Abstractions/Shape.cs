namespace PrototypePattern.Abstractions
{
    abstract class Shape : IPrototype
    {
        private int x;
        private int y;

        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Shape(Shape prototype)
        {
            x = prototype.x;
            y = prototype.y;
        }

        public abstract IPrototype Clone();

        public virtual string GetDetails()
            => $"X: {x}    Y:{y}";
    }
}
