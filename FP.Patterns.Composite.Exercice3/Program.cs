using FP.Patterns.Composite.Exercice3;

IndividualEmployee carlos = new IndividualEmployee("carlos", 1234);
IndividualEmployee gustavo = new IndividualEmployee("gustavo", 2345);
IndividualEmployee andres = new IndividualEmployee("andres", 3456);
IndividualEmployee julian = new IndividualEmployee("julian", 4321);
IndividualEmployee roberto = new IndividualEmployee("roberto", 5432);
IndividualEmployee bryan = new IndividualEmployee("bryan", 6344);
IndividualEmployee frank = new IndividualEmployee("frank", 1234);
IndividualEmployee diego = new IndividualEmployee("diego", 3456);

GroupEmployee salesTeam = new GroupEmployee("Sales");
salesTeam.AddEmployee(carlos);
salesTeam.AddEmployee(gustavo);
salesTeam.AddEmployee(andres);
salesTeam.AddEmployee(julian);

GroupEmployee itTeam = new GroupEmployee("IT");
itTeam.AddEmployee(roberto);
itTeam.AddEmployee(bryan);
itTeam.AddEmployee(frank);
itTeam.AddEmployee(diego);

GroupEmployee organization = new("Extreme");
organization.AddEmployee(salesTeam);
organization.AddEmployee(itTeam);

Console.WriteLine(organization.GetSalary());