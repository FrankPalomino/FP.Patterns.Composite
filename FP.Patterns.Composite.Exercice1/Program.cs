using FP.Patterns.Composite.Exercice1;

Square square = new Square(5);
Triangle triangle = new Triangle(5);
Circle circle = new Circle(5);

GeometricComposite composite = new GeometricComposite();
composite.Add(square);
composite.Add(triangle);
composite.Add(circle);

Console.WriteLine(composite.CalculateArea());

