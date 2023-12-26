namespace FP.Patterns.Composite.Exercice1
{
    internal class Square : IGeometricComposite
    {
        private int _side;
        public int CalculateArea()
        {
            return _side * _side;
        }

        public int CalculatePerimeter()
        {
            return _side * 4;
        }

        public Square(int side)
        {
            _side = side;
        }
    }
}
