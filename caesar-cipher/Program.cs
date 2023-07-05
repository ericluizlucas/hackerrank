class Result
{

    /*
     * Complete the 'caesarCipher' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static string caesarCipher(string s, int k)
    {
        List<string> alphabet = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        char[] splited = s.ToCharArray();
        string[] letters = new string[splited.Count()];

        for(int j = 0; j < splited.Count(); j++)
        {
            bool done = false;
            if(!done)
            {
            for(int i = 0; i<alphabet.Count(); i++)
            {
                var letter = splited[j].ToString();
                bool isUpper = char.IsUpper(splited[j]);
                var nowAlph = isUpper ? alphabet[i].ToUpper() : alphabet[i];
                if(!done) letters[j] = letter;

                if(letter == nowAlph)
                {
                    letters[j] = (i + k) >= alphabet.Count() ? alphabet[i+k - alphabet.Count()] : alphabet[i+k];
                    if(isUpper) letters[j] = letters[j].ToUpper();
                    done = true;
                }
            }
            }
        }
        string resp = "";
        foreach(var obj in letters)
        {
            resp += obj;
        }

        return resp;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string s = "middle-Outz";

        int k = 2;

        string result = Result.caesarCipher(s, k);
        Console.WriteLine(result);
    }
}