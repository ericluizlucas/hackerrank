class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int length = arr.Count();
        int primaryDiagSum = 0;
        int secondaryDiagSum = 0;
        
        for(int i = 0; i < length; i++)
        {
            primaryDiagSum += arr[i][i];
            secondaryDiagSum += arr[i][length - 1 - i];
        }
        return Math.Abs(primaryDiagSum - secondaryDiagSum);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        List<List<int>> arr = new List<List<int>>() {
            new List<int>() {11, 2, 4},
            new List<int>() {4, 5, 6},
            new List<int>() {10, 8, -12}
            };

        int result = Result.diagonalDifference(arr);
        Console.WriteLine(result);
    }
}