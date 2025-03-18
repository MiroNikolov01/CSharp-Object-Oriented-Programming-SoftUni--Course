using BorderControl.Interfaces;

namespace BorderControl;

public class Rebel : BaseModel ,IBuyer
{
    public int Food { get; set; }
    public Rebel(string name,int age,string group)
    {
        Name = name;
        Age = age;
        Group = group;
    }

    public int BuyFood()
    {
        Food += 10;
        return 5;
    }
}