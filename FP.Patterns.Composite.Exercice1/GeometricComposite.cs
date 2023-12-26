namespace FP.Patterns.Composite.Exercice1
{
    internal class GeometricComposite : IGeometricComposite
    {
        private List<IGeometricComposite> _elements = new List<IGeometricComposite>();
        public int CalculateArea()
        {
            int area = 0;
            foreach (var element in _elements)
            {
                area += element.CalculateArea();
            }
            return area;
        }

        public int CalculatePerimeter()
        {
            int perimeter = 0;
            foreach (var element in _elements)
            {
                perimeter += element.CalculatePerimeter();
            }
            return perimeter;
        }

        public void Add(IGeometricComposite element)
        {
            _elements.Add(element);
        }

        public void Remove(IGeometricComposite element)
        {
            _elements.Remove(element);
        }
    }
}
