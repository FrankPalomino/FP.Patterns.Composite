
namespace FP.Patterns.Composite.Exercice3
{
    public class GroupEmployee : IEmployee
    {
        public string Name { get; }

        public Guid EmployeeId { get; }

        public List<IEmployee> Employees { get; }

        public GroupEmployee(string name)
        {
            Name = name;
            EmployeeId = Guid.NewGuid();
            Employees = [];
        }
        public decimal GetSalary()
        {
            decimal salary = 0;
            foreach (var employee in Employees)
            {
                salary += employee.GetSalary();
            }
            return salary;
        }

        public void AddEmployee(IEmployee employee)
        {
            Employees.Add(employee);
        }
    }
}
