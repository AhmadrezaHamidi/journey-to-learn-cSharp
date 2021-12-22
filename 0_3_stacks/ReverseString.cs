
public class ReverseString
{
    public readonly string _input;
    public readonly Stack<char> _stack;

    public ReverseString(string input)
    {
        _input = input;
    }
    public string SetStack()
    {
        foreach (var item in _input)
        {
            _stack.Push(item);
        }
        var List = new List<char>();
        foreach (var t in _stack)
        {
            List.Add(t);
        }

        return new string(List.ToArray());
    }


}