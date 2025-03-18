using BorderControl.Interfaces;

namespace BorderControl;

public class Robot : BaseModel
{

    public Robot(string model, string id)
    {
        Model = model;
        Id = id;
    }
    
}