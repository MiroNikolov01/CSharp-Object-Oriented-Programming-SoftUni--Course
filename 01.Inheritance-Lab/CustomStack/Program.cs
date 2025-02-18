namespace CustomStack;

public class StartUp
{
    static void Main(string[] args)
    {
       List<string> randomList = new List<string>();
       randomList.Add("A");
       randomList.Add("B");
       randomList.Add("C");
       StackOfStrings stackOfStrings = new StackOfStrings();
       Stack<string> stack = stackOfStrings.AddRange(randomList);
    }
}