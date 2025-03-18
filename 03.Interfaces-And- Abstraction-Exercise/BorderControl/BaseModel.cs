using BorderControl.Interfaces;

namespace BorderControl;

public abstract class BaseModel : IRobot, ICitizen, IBirthable, IRebel
{
    public string Name { get; set; }
    public string Model { get; set; }
    public int Age { get; set; }
    public string Id { get; set; }
    public string BirthDate { get; set; }
    public string Group { get; set; }
}