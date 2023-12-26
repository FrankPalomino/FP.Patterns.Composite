namespace FP.Patterns.Composite.Exercice2
{
    public class CompositeFileSystemComponent : IFileSystemComponent
    {
        private readonly List<IFileSystemComponent> _component = new ();
        public void Display()
        {
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
