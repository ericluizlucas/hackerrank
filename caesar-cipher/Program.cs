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
        string resp = "";

        for(int i = 0; i<s.Count(); i++)
        {
            bool isUpper = false;
            if(char.IsUpper(splited[i])) isUpper = true;
            int idx = alphabet.IndexOf(splited[i].ToString().ToLower());
            if(idx == -1) resp += splited[i];
            else
            {
            string item = (idx + k) >= alphabet.Count() ? alphabet[idx + k - alphabet.Count()] : alphabet[idx + k];
            if(isUpper) item = item.ToUpper();
            resp += item;
            Console.WriteLine(resp);
            }
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