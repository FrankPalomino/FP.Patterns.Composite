namespace FP.Patterns.Composite.Exercice4
{
    public class MyFile : IFileSystemComponent
    {
        private readonly string _name;
        private readonly string _text;

        public MyFile(string name, string text)
        {
            _name = name;
            _text = text;
        }

        public void Display()
        {
            Console.WriteLine($"File {_name}: {_text}");
        }
    }
}
