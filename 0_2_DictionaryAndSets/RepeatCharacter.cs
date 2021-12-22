using System.Security.Cryptography.X509Certificates;
public class RepeatCharacter
{
    Dictionary<char, int> Charex = new Dictionary<char, int>();
    private readonly string input;
    public RepeatCharacter(string Input)
    {
        input = Input;
    }
    // public char DontRepeat()
    // {
    //     char res = ' ';
    //     for (var i = 0; i < input.Length; i++)
    //     {
    //         try
    //         {
    //             Charex.Add(input[i], i);
    //         }
    //         catch
    //         {
    //             res = Charex.LastOrDefault().Key;
    //             break;
    //         }
    //     }
    //     return res;

    // }
    public char Repeat()
    {
        for (var i = 0; i < input.Length; i++)
        {
            if (input[i] != null)
            {

                var index = input[i];
                if (Charex.ContainsKey(index))
                {
                    var count = Charex.GetValueOrDefault(index);
                    try
                    {
                        Charex[input[i]] = count + 1;
                    }
                    catch
                    {

                    }
                }
                else
                {
                    Charex.Add(input[i], 1);
                }
            }
        }
        return Charex.Where(x => x.Value.Equals(1)).FirstOrDefault().Key;
    }
}