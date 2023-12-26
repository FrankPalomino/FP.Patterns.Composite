namespace FP.Patterns.Composite
{
    internal class Ingredient : Component
    {
        public int Count { get; set; }
        public string Unit { get; set; }
        public Ingredient(string name, decimal price, int count, string unit) : base(name, price)
        {
            Count = count;
            Unit = unit;
        }
    }
}
