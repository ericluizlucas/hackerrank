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

//      Example:

// s = '12:01:00PM"
// Return '12:01:00'.

// s = '12:01:00AM"
// Return '00:01:00'.

class Result
{
    public static string timeConversion(string s)
    {
        return DateTime.Parse(s).ToString("HH:mm:ss");
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string s = "07:05:45AM";

        string result = Result.timeConversion(s);
        Console.WriteLine(result);
    }
}