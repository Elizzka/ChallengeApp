bool isWomen = true;
var age = 27;
var name = "Ewa";

if (isWomen)
{
    if (age < 30)

    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if (name == "Ewa" && age == 33)

    {
        Console.WriteLine("Ewa, lat 33");
    }
}
else 
{
    if (age > 18)
    {
        Console.WriteLine("Pełnoletni mężczyzna");
    }
    else if (age < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
}



