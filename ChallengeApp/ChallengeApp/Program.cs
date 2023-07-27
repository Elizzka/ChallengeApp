using ChallengeApp;

Employee employee1 = new Employee("Kuba", "Majewski", 25);
Employee employee2 = new Employee("Natalia", "Konieczna", 34);
Employee employee3 = new Employee("Paulina", "Kowalska", 42);

employee1.AddScore(6);
employee1.AddScore(7);
employee1.AddScore(6);
employee1.AddScore(9);
employee1.AddScore(2);

employee2.AddScore(7);
employee2.AddScore(7);
employee2.AddScore(9);
employee2.AddScore(8);
employee2.AddScore(9);

employee3.AddScore(5);
employee3.AddScore(4);
employee3.AddScore(6);
employee3.AddScore(2);
employee3.AddScore(4);

List<Employee> employees = new List<Employee>()
{ 
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if(employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}

Console.WriteLine("Pracownik z najwyższym wynikiem: " + employeeWithMaxResult.Name + " "
    + employeeWithMaxResult.Surname + " " + employeeWithMaxResult.Age + " lata " + "Wynik: " + maxResult);






