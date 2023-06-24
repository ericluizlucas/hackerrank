class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<Int64> arr)
    {
        arr.Sort();
        Int64 maxSum = 0;
        Int64 minSum = 0;

        for (int i = 0; i < arr.Count(); i++)
        {
            if (i != 0) maxSum += arr[i];
            if (i != (arr.Count() - 1)) minSum += arr[i];
        }
        Console.WriteLine($"{minSum} {maxSum}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<Int64> arr = new List<Int64> { 1, 2, 3, 4, 5 };

        Result.miniMaxSum(arr);
    }
}