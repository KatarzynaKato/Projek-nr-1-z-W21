
string name = "Ewa";
string sex = "kobieta";
int age = 33;

if (sex == "kobieta")
{
    if (name == "Ewa" && age == 33) 
    {
        Console.WriteLine("Ewa lat 33");
    }
    else if (name != "Ewa" && age > 30) 
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
}

if (sex != "kobieta" && age > 18) 
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}