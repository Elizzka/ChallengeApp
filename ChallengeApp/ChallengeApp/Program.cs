using ChallengeApp;

var employee = new Employee("Maja", "Wiśniewska");
employee.AddGrade(4);
employee.AddGrade(2);
employee.AddGrade(5);
employee.AddGrade(7);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

void SetSth(ref Statistics statistics)
{
    statistics = new Statistics();
}


