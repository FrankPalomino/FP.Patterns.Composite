using FP.Patterns.Composite;

Ingredient flour = new Ingredient("Flour", 0.5m, 500, "g");
Ingredient sugar = new Ingredient("Sugar", 0.3m, 250, "g");
Ingredient butter = new Ingredient("Butter", 0.8m, 250, "g");
Ingredient eggs = new Ingredient("Eggs", 0.2m, 4, "pcs");
Ingredient milk = new Ingredient("Milk", 0.4m, 250, "ml");

Cake cake = new Cake("Milk Cake");
cake.Add(flour);
cake.Add(sugar);
cake.Add(butter);
cake.Add(eggs);
cake.Add(milk);

Console.WriteLine($"Price of {cake.Name} is {cake.Price} EUR");

Cake chocolateMilkCake = new Cake("Chocolate Cake");

Ingredient chocolate = new Ingredient("Chocolate", 1.5m, 200, "g");
chocolateMilkCake.Add(chocolate);
chocolateMilkCake.Add(cake);

Console.WriteLine($"Price of {chocolateMilkCake.Name} is {chocolateMilkCake.Price} EUR");