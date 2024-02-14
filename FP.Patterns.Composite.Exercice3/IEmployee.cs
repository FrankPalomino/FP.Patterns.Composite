namespace FP.Patterns.Composite.Exercice3
{
    public interface IEmployee
    {
        string Name { get; }
        decimal GetSalary();
        Guid EmployeeId { get; }
    }
}
