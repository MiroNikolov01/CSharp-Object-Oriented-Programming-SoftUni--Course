namespace Raiding.Interfaces;

public interface IHero
{
    public string Name { get; }
    public int Power { get; }
    string CastAbility();
}