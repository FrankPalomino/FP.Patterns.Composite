using FP.Patterns.Composite.Exercice4;

MyFile poem1 = new("Poem 1", "This is a poem 1");
MyFile poem2 = new("Poem 2", "This is a poem 2");
MyDirectory poems = new("Poems");
poems.Add(poem1);
poems.Add(poem2);

MyFile work1 = new("Work 1", "This is a work 1");
MyFile work2 = new("Work 2" ,"This is a work 2");
MyDirectory works = new("Works");
works.Add(work1);
works.Add(work2);

MyDirectory root = new("Root Directory");
root.Add(works);
root.Add(poems);

root.Display();
