namespace FP.Patterns.Composite.Exercice2
{
    public class FileComponent : IFileSystemComponent
    {
        private readonly string _name;

        public FileComponent(string name)
        {
            _name = name;
        }

        public void Display()
        {
            Console.WriteLine($"This is a File named: {_name} ");
        }
    }
}
