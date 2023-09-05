using ChallengeApp;

var employee = new Employee("Maja", "Wiśniewska");
employee.AddGrade("600,14");
employee.AddGrade("3,3333");
employee.AddGrade(5f);
employee.AddGrade("Maja");
employee.AddGrade("2,1654");

var statistics = employee.GetStatistics();

Console.WriteLine($"Wynik pracownika: {employee.Name} {employee.Surname}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min:N2}");
Console.WriteLine($"Max: {statistics.Max:N2}");

void SetSth(ref Statistics statistics)
{
    statistics = new Statistics();
}


