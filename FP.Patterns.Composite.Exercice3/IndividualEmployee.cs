namespace FP.Patterns.Composite.Exercice3
{
    public class IndividualEmployee : IEmployee
    {
        public string Name { get; }

        public Guid EmployeeId { get; }

        private decimal _salary;

        public IndividualEmployee(string name, decimal salary)
        {
            Name = name;
            _salary = salary;
            EmployeeId = Guid.NewGuid();
        }

        public decimal GetSalary()
        {
            return _salary;
        }
    }
}
