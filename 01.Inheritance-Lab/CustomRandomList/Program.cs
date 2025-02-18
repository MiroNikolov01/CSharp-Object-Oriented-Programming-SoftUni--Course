namespace CustomRandomList;

public class StartUp
{
    static void Main()
    {
        List<string> collection = new List<string>();
        collection.Add("cat");
        collection.Add("dog");
        collection.Add("puppy");
        RandomList randomList = new RandomList();
        randomList.Add("elephant");
        Console.WriteLine(randomList.RandomString(collection));
    }
}