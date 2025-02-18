namespace CustomStack;

public class StackOfStrings : Stack<string>
{
    public bool IsEmpty() => Count == 0;

    public Stack<string> AddRange(IEnumerable<string> collection)
    {
        foreach (var item in collection)
        {
            Push(item);
        }
        return this;
    }
}