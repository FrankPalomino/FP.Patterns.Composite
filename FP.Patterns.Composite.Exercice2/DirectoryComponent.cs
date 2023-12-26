namespace FP.Patterns.Composite.Exercice2
{
    public class DirectoryComponent : IFileSystemComponent
    {

        private readonly List<IFileSystemComponent> _component;
        private readonly string _name;

        public DirectoryComponent(string name)
        {
            _name = name;
            _component = new List<IFileSystemComponent>();
        }

        public void Display()
        {
            Console.WriteLine($"This is a Directory named: {_name}.");
            foreach(IFileSystemComponent component in _component)
            {
                component.Display();
            }
        }

        public void Add(IFileSystemComponent component)
        {
            _component.Add(component);
        }

        public void Remove(IFileSystemComponent component)
        {
            _component.Remove(component);
        }
    }
}
