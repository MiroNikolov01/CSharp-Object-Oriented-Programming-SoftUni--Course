namespace FootballTeamGenerator;

class Program
{
    static void Main()
    {
        Dictionary<string, Team> teams = new Dictionary<string, Team>();
        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            try
            {
                ProcessCommand(command, teams);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    public static void ProcessCommand(string input, Dictionary<string, Team> teams)
    {
        string[] data = input.Split(";", StringSplitOptions.RemoveEmptyEntries);
        string command = data[0];
        string teamName = data[1];

        if (command == "Team")
        {
            Team team = new Team(teamName);
            teams.Add(team.Name, team);
        }
        else
        {
            if (!teams.ContainsKey(teamName))
            {
                Console.WriteLine($"Team {teamName} does not exist.");
                return;
            }

            Team team = teams[teamName];

            if (command == "Add")
            {
                Player player = new Player(data[2],
                    int.Parse(data[3]),
                    int.Parse(data[4]),
                    int.Parse(data[5]),
                    int.Parse(data[6]),
                    int.Parse(data[7]));
                team.AddPlayer(player);
            }
            else if (command == "Remove")
            {
                string playerName = data[2];
                if (!team.RemovePlayer(playerName))
                {
                    Console.WriteLine($"Player {playerName} is not in {team.Name} team.");
                }
            }
            else if (command == "Rating")
            {
                Console.WriteLine($"{teamName} - {team.Rating:F0}");
            }
        }
    }
}