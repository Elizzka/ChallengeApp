using ChallengeApp;

Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

var supervisor = new Supervisor("Maja", "Wiśniewska");

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika:");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }

    try
    {
        supervisor.AddGrade(input);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

var statistics = supervisor.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Average: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");






