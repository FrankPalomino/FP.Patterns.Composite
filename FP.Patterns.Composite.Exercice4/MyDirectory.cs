namespace FP.Patterns.Composite.Exercice4
{
    public class MyDirectory : IFileSystemComponent
    {
        private readonly string _name;
        private readonly List<IFileSystemComponent> _components;

        public MyDirectory(string name)
        {
            _name = name;
            _components = [];
        }

        public void Add(IFileSystemComponent component)
        {
            _components.Add(component);
        }

        public void Remove(IFileSystemComponent component)
        {
            _components.Remove(component);
        }

        public void Display()
        {
            Console.WriteLine($"Directory {_name} contains:\n");
            foreach (IFileSystemComponent component in _components)
            {
                component.Display();
            }
        }
    }
}
