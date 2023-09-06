using ChallengeApp;

var employee = new Employee("Maja", "Wiśniewska");
employee.AddGrade(7);
employee.AddGrade("3,3333");
employee.AddGrade(5f);
employee.AddGrade("588,15");
employee.AddGrade(2);

var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithDoWhile();
var statistics3 = employee.GetStatisticsWithWhile();
var statistics4 = employee.GetStatisticsWithFor();

Console.WriteLine("GetStatisticWithForEach");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");

Console.WriteLine("GetStatisticWithDoWhile");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");

Console.WriteLine("GetStatisticWithWhile");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");

Console.WriteLine("GetStatisticWithFor");
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");

//Console.WriteLine($"Wynik pracownika: {employee.Name} {employee.Surname}");
//Console.WriteLine($"Average: {statistics.Average:N2}");
//Console.WriteLine($"Min: {statistics.Min:N2}");
//Console.WriteLine($"Max: {statistics.Max:N2}");

//void SetSth(ref Statistics statistics)
//{
//  statistics = new Statistics();
//}


