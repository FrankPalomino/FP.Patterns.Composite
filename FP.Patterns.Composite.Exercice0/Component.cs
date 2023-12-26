namespace FP.Patterns.Composite
{
    internal abstract class Component
    {
        public string Name { get; set; }
        public virtual decimal Price { get; set; }

        public Component(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
