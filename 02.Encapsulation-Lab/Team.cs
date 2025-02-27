namespace PersonsInfo;

public class Team
{
    private readonly string name;
    private readonly List<Person> firstTeam;
    private readonly List<Person> reserveTeam;

    public string Name => name;
    public IReadOnlyCollection<Person> FirstTeam { get; }
    public IReadOnlyCollection<Person> ReserveTeam { get; }

    public Team(string name)
    {
        this.name = name;
        firstTeam = new List<Person>();
        FirstTeam = firstTeam.AsReadOnly();
        
        reserveTeam = new List<Person>();
        ReserveTeam = reserveTeam.AsReadOnly();
    }

    public void AddPlayer(Person person)
    {
        if(person is null) throw new ArgumentNullException(nameof(person));
        
        if(person.Age < 40) firstTeam.Add(person);
        else reserveTeam.Add(person);
    }
}