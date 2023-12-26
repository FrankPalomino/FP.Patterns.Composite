namespace FP.Patterns.Composite
{
    internal class Cake : Component
    {
        private List<Component> _ingredients = new List<Component>();
        public override decimal Price
        {
            get
            {
                decimal price = 0;
                foreach (var ingredient in _ingredients)
                {
                    price += ingredient.Price;
                }
                return price;
            }
        }

        public void Add(Component element)
        {
            _ingredients.Add(element);
        }

        public void Remove(Component element)
        {
            _ingredients.Remove(element);
        }

        public Cake(string name, decimal price = 0) : base(name, price)
        {

        }
    }
}
