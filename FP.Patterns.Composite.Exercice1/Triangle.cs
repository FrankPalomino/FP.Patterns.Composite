namespace FP.Patterns.Composite.Exercice1
{
    internal class Triangle : IGeometricComposite
    {
        private int _side;
        public int CalculateArea()
        {
            return _side * _side / 2;
        }

        public int CalculatePerimeter()
        {
            return _side * 3;
        }

        public Triangle(int side)
        {
            _side = side;
        }
    }
}
