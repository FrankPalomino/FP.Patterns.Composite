namespace FP.Patterns.Composite.Exercice1
{
    internal class Circle : IGeometricComposite
    {
        private int _radius;
        public int CalculateArea()
        {
            return (int)(Math.PI * _radius * _radius);
        }

        public int CalculatePerimeter()
        {
            return (int)(2 * Math.PI * _radius);
        }

        public Circle(int radius)
        {
            _radius = radius;
        }
    }
}
