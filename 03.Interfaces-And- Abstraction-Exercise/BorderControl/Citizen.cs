using System.Runtime.CompilerServices;
using BorderControl.Interfaces;

namespace BorderControl;

public class Citizen : BaseModel , IBuyer
{
    public int Food { get; set; }
    public Citizen(string name, int age, string id,string birthDate)
    {
        Name = name;
        Age = age;
        Id = id;
        BirthDate = birthDate;
    }
    public int BuyFood()
    {
        Food += 10;
        return 10;
    }
}