class Program
{
    static void Main(string[] args)
    {
        Solution.RemoveElement([1, 1, 1], 1);
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
        int[] result = new int[nums.Length];
        int left = 0;
        int right = nums.Length - 1;
        int index = nums.Length - 1;
        while (left <= right)
        {
            if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
            {
                result[index] = nums[left] * nums[left];
                left++;
            }
            else
            {
                result[index] = nums[right] * nums[right];
                right--;
            }
            index--;
        }
        return result;
    }

    public static int RemoveElement(int[] nums, int val)
    {
        var count = 0;
        int left;
        int right;
        var length = nums.Length;

        if (length == 1 && val == nums[0]) return 0;
        if (length == 1 && val != nums[0]) return 1;

        for (int i = 0; i < length; i++)
        {
            if (nums[i] != val)
            {
                continue;
            };
            for (int j = length - 1; j >= 0; j--)
            {
                if (nums[j] == val)
                {
                    length--;
                    count++;
                    continue;
                }
                if (nums[j] != val && i < j)
                {
                    left = nums[i];
                    right = nums[j];
                    nums[i] = right;
                    nums[j] = left;
                    count++;
                    length--;
                    break;
                }
                if (nums[j] == nums[i] && i == j)
                {
                    length--;
                    count++;
                    break;
                }
            }
        }
        return nums.Length - count;
    }
}