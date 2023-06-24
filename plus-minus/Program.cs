class Result
{
    public static void plusMinus(List<int> arr)
    {
        decimal elementsCount = arr.Count();
        decimal positiveCount = 0.000000m;
        decimal negativeCount = 0.000000m;
        decimal zeroCount = 0.000000m;
        foreach (var item in arr)
        {
            if (item > 0)
            {
                positiveCount += 1m;
            }
            else if (item < 0)
            {
                negativeCount += 1m;
            }
            else
                zeroCount += 1m;
        }

        Console.WriteLine(Math.Round(positiveCount / elementsCount, 6));
        Console.WriteLine(Math.Round(negativeCount / elementsCount, 6));
        Console.WriteLine(Math.Round(zeroCount / elementsCount, 6));
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        // int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = new List<int> { -4, 3, -9, 0, 4, 1 };
        // Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}