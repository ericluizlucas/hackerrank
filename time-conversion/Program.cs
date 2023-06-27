//      Function Description:

// Complete the timeConversion function in the editor below. It should return a new string representing the input time in 24 hour format.

//      timeConversion has the following parameter(s):

// string s: a time in  hour format

//      Returns:

// string: the time in  hour format
// Input Format

// A single string  that represents a time in -hour clock format (i.e.:  or ).

//      Constraints:

// All input times are valid

class Result
{
    public static string timeConversion(string s)
    {
        return DateTime.Parse(s).ToString("H:mm:ss");
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string s = "07:05:45PM";

        string result = Result.timeConversion(s);
        Console.WriteLine(result);
    }
}