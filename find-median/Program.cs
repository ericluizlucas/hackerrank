﻿class Result
{

    /*
     * Complete the 'findMedian' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int findMedian(List<int> arr)
    {
        arr.Sort();
        int indexMiddle = arr.Count()/2;
        return arr[indexMiddle];
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> arr = new List<int> { 0, 1, 2, 4, 6, 5, 3 };

        int result = Result.findMedian(arr);
        Console.WriteLine(result);
    }
}
