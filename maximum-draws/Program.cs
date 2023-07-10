class Result
{

    /*
     * Complete the 'maximumDraws' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     */

    public static int maximumDraws(int n)
    {
        return n+1;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> numberList = new List<int>() { 1, 2 };

        foreach (var item in numberList)
        {
            int result = Result.maximumDraws(item);
            Console.WriteLine(result);
        }
    }
}