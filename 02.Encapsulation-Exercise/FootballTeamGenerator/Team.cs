using System.Runtime.CompilerServices;

namespace FootballTeamGenerator;

public class Team
{
    private readonly Dictionary<string, Player> _players;
    public string Name { get; }
    public double Rating => (this._players.Count == 0 ? 0 : this._players.Average(x => x.Value.SkillLevel));

    public Team(string name)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("A name should not be empty.");
        this.Name = name;
        this._players = new Dictionary<string, Player>();
    }

    public void AddPlayer(Player player) => this._players[player.Name] = player;
    public bool RemovePlayer(string playerName) => this._players.Remove(playerName);
}