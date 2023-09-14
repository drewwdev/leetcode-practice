// problem: https://leetcode.com/problems/majority-element/?envType=study-plan-v2&envId=top-interview-150


public class Solution
{
    public int MajorityElement(int[] nums)
    {

        Dictionary<int, int> numberCounts = new Dictionary<int, int>();
        int currentIndex = 0;

        while (currentIndex < nums.Length)
        {
            int currentNumber = nums[currentIndex];

            if (!numberCounts.ContainsKey(currentNumber))
            {
                numberCounts[currentNumber] = 1;
            }
            else
            {
                numberCounts[currentNumber]++;
            }

            currentIndex++;
        }

        int mostCommonNumber = 0;
        int highestCount = 0;

        foreach (var kvp in numberCounts)
        {
            if (kvp.Value > highestCount)
            {
                mostCommonNumber = kvp.Key;
                highestCount = kvp.Value;
            }
        }

        return mostCommonNumber;
    }
}
