namespace BorderControl;

class Program
{
    // This solution involves 3 problems in one
    static void Main(string[] args)
    {
        List<BaseModel> models = new List<BaseModel>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] data = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            switch (data.Length)
            {
                case 4:
                    Citizen citizen = ReadCitizen(data);
                     models.Add(citizen);
                    break;
                case 3:
                    Rebel rebel = ReadRebel(data);
                    models.Add(rebel);
                    break;
            }
        }

        int totalFood = 0;
        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            BaseModel? model = models.FirstOrDefault(m => m.Name == command);
            if (model is null)
            {
                continue;
            }
            if (model is Citizen citizen)
            {
                totalFood += citizen.BuyFood();
            }
            else if (model is Rebel rebel)
            {
                totalFood += rebel.BuyFood();
            }
        }

        Console.WriteLine($"{totalFood}");

        //     this is from previous 2 tasks
        // string year = Console.ReadLine();
        // foreach (var model in models)
        // {
        //     if (model.BirthDate.EndsWith(year))
        //     {
        //         Console.WriteLine(model.BirthDate);
        //     }
        // }
    }

    private static Rebel ReadRebel(string[] data)
    {
        string name = data[0];
        int age = int.Parse(data[1]);
        string group = data[2];
        Rebel rebel = new Rebel(name, age, group);
        return rebel;
    }

    private static Citizen ReadCitizen(string[] data)
    {
        string citizenName = data[0];
        int citizenAge = int.Parse(data[1]);
        string citizenId = data[2];
        string birthDate = data[3];

        Citizen citizen = new Citizen(citizenName, citizenAge, citizenId, birthDate);
        return citizen;
    }

    private static Robot ReadRobot(string[] data)
    {
        string robotModel = data[1];
        string robotId = data[2];

        Robot robot = new Robot(robotModel, robotId);
        return robot;
    }

    private static Pet ReadPet(string[] data)
    {
        string petName = data[1];
        string petBirthDate = data[2];

        Pet pet = new Pet(petName, petBirthDate);
        return pet;
    }
}