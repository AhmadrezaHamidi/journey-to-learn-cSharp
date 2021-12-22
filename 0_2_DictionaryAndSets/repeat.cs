public class repeat
{
    //A green apple 
    //e is repeted twice
    HashSet<char> myhash1 = new HashSet<char>();
    private readonly string Input;
    public repeat(string input)
    {
        Input = input;
    }
    public char repetCharecter()
    {
        var res = ' ';
        foreach (var item in Input)
        {
            if (myhash1.Contains(item))
            {
                res = item; break;
            }
            else
                myhash1.Add(item);
        }
        return res;
    }
}