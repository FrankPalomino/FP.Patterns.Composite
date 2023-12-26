using FP.Patterns.Composite.Exercice2;

FileComponent photo = new FileComponent("House");
FileComponent photo2 = new FileComponent("Car");

DirectoryComponent directory = new DirectoryComponent("Images");
directory.Add(photo);
directory.Add(photo2);

CompositeFileSystemComponent root = new CompositeFileSystemComponent();
root.Add(directory);
root.Display();
