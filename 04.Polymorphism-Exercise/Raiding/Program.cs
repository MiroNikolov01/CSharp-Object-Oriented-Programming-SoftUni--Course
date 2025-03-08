using Raiding.Heroes;

namespace Raiding;

class Program
{
    static void Main()
    {
        List<BaseHero> heroes = new List<BaseHero>();
        int n = int.Parse(Console.ReadLine()!);
        while (heroes.Count < n)
        {
            CollectHeroes(heroes);
        }

        int bossPower = int.Parse(Console.ReadLine()!);
        foreach (var hero in heroes)
        {
            Console.WriteLine(hero.CastAbility());
        }

        Console.WriteLine(PrintFinalResult(bossPower, heroes));
    }

    private static string PrintFinalResult(int bossPoints, List<BaseHero> heroes)
    {
        int totalHeroPoints = heroes.Sum(h => h.Power);

        return bossPoints <= totalHeroPoints ? "Victory!" : "Defeat...";
    }

    private static void CollectHeroes(List<BaseHero> heroes)
    {
        string? heroName = Console.ReadLine();
        string? heroType = Console.ReadLine();
        BaseHero? hero = heroType switch
        {
            "Paladin" => new Paladin(heroName!),
            "Druid" => new Druid(heroName!),
            "Rogue" => new Rogue(heroName!),
            "Warrior" => new Warrior(heroName!),
            _ => null
        };
        if (hero is null)
        {
            Console.WriteLine("Invalid hero!");
            return;
        }

        heroes.Add(hero);
    }
}