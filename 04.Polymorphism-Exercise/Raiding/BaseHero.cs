using Raiding.Heroes;
using Raiding.Interfaces;

namespace Raiding;

public abstract class BaseHero : IHero
{
    public string Name { get; }
    public int Power { get; protected set; }
    protected BaseHero(string name)
    {
        this.Name = name;
    }
    public virtual string CastAbility()
    {
        throw new ArgumentException("Cannot cast an ability on an object of type BaseHero.");
    }
}