class Program
{
    static void Main(string[] args)
    {
        Solution.FindNumbers(new int[] { 112, 123, 123, 121, 121, 121 });
    }
}

static class Solution
{
    public static string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0) // if the array is null or empty
            return ""; // return an empty string
        for (int prefixLen = 0; prefixLen < strs[0].Length; prefixLen++) // loop through the first string
        {
            char c = strs[0][prefixLen]; // get the character at the current index
            for (int i = 1; i < strs.Length; i++) // loop through the rest of the strings
            {
                if (prefixLen >= strs[i].Length || strs[i][prefixLen] != c) // if the current index is greater than the length of the current string or the character at the current index is not equal to the character at the same index in the first string
                    return strs[0].Substring(0, prefixLen); // return the substring of the first string from index 0 to prefixLen
            } // if the character at the current index is equal to the character at the same index in the first string, continue the loop
        }
        return strs[0];
    }

    public static int FindMaxConsecutiveOnes(int[] nums)
    {
        int max = 0;
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                count++;
                max = Math.Max(max, count);
            }
            else
            {
                count = 0;
            }
        }
        return max;
    }


    public static int FindNumbers(int[] nums)
    {
        var digits = 0;
        var items = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int number = nums[i];
            while (number > 0)
            {
                digits++;
                number /= 10;
            }
            if (digits % 2 == 0) items++;
            digits = 0;
        }
        return items;
    }

    public static int[] SortedSquares(int[] nums)
    {

    }
}