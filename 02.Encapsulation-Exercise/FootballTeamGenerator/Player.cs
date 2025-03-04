namespace FootballTeamGenerator;

public class Player
{
    private const double StatsCount = 5.0;
    private int endurance, sprint, dribble, passing, shooting;
    public string Name { get; }

    public int Endurance
    {
        get => endurance;
        private set => endurance = ValidateStat("Endurance", value);
    }

    public int Sprint
    {
        get => sprint;
        private set => sprint = ValidateStat("Sprint", value);
    }

    public int Dribble
    {
        get => dribble;
        private set => dribble = ValidateStat("Dribble", value);
    }

    public int Passing
    {
        get => passing;
        private set => passing = ValidateStat("Passing", value);
    }

    public int Shooting
    {
        get => shooting;
        private set => shooting = ValidateStat("Shooting", value);
    }

    public double SkillLevel 
        => (this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / StatsCount;

    public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("A name should not be empty.");
        }
        Name = name;
        Endurance = endurance;
        Sprint = sprint;
        Dribble = dribble;
        Passing = passing;
        Shooting = shooting;
    }

    private int ValidateStat(string statName, int value)
    {
        if (value < 0 || value > 100)
        {
            throw new ArgumentException($"{statName} should be between 0 and 100.");
        }

        return value;
    }
}