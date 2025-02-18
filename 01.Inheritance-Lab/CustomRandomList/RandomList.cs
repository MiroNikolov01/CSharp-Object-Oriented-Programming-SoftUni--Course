namespace CustomRandomList;

public class RandomList : List<string>
{
    public string RandomString(List<string> collection)
    {
        Random random = new Random();
        int index = random.Next(0, collection.Count());
        string removedElement = collection.ElementAt(index);
        collection.RemoveAt(index);
        return removedElement;
    }
}