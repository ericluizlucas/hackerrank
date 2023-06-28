class Result
{

    /*
     * Complete the 'lonelyinteger' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int lonelyinteger(List<int> a)
    {
        int lonelyint = -1;
        
        for(int i = 0; i < a.Count(); i++)
        {
            bool unique = true;
            for(int j = 0; j < a.Count(); j++)
            {
                    if(a[i] == a[j] && i != j) 
                    {
                        unique = false;
                    }
            }
            if(unique == true) lonelyint = a[i];
        }

        return lonelyint;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> a = new List<int> { 1, 2, 3, 4, 3, 2, 1};

        int result = Result.lonelyinteger(a);
        Console.WriteLine(result);
    }
}