public class BlancedString
{
    private readonly string _input;
    public BlancedString(string Input)
    {
        _input = Input;
    }

    private static List<char> LeftElemnt = new List<char>() { '(', '{', '<' };
    private static List<char> RightElemnt = new List<char>() { ')', '}', '>' };
    Stack<char> stack = new Stack<char>();


    private bool CheckRightlemnt(char input)
    {
        return RightElemnt.Contains(input);
    }

    private bool CheckLeftelement(char input)
    {
        return LeftElemnt.Contains(input);
    }
    private bool checkIndex(char left, char right)
    {
        if (LeftElemnt.IndexOf(left) == RightElemnt.IndexOf(right))
            return true;
        else
            return false;
    }
    public bool checkedBalanced()
    {
        var res = false;
        for (var i = 0; i < _input.Length; i++)
        {
            char character = _input[i];
            char top = ' ';
            if (CheckLeftelement(character))
                stack.Push(character);
            else if (CheckRightlemnt(character) && stack.Any()) // 
            {
                try
                {
                    top = stack.Pop();
                }
                catch (ArgumentNullException ex)
                {
                    ///No impelemetiopn
                }
                if (checkIndex(character, top))
                    res = true;
            }
        }
        return res;
    }
}