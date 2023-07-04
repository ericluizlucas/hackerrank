class Result
{

    /*
     * Complete the 'countingSort' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static List<int> countingSort(List<int> arr)
    {
        int[] aux = new int[100];
        List<int> result = new List<int>();
        for (int i = 0; i < aux.Length; i++)
        {
            int frequency = 0;

            foreach (int item in arr)
            {
                if (item == i) frequency += 1;
            }
            result.Add(frequency);
        }

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> arr = new List<int>() { 1,1,3,2,1 };
        List<int> result = Result.countingSort(arr);

        foreach (var item in result)
        {
            Console.Write($" {item}");
        }
    }
}