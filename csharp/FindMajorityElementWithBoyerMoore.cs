// problem: https://leetcode.com/problems/majority-element/?envType=study-plan-v2&envId=top-interview-150

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int candidate = 0;
        int count = 0;

        foreach (int num in nums)
        {
            if (count == 0)
            {
                candidate = num;
                count = 1;
            }
            else if (num == candidate)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        int totalCount = 0;
        foreach (int num in nums)
        {
            if (num == candidate)
            {
                totalCount++;
            }
        }

        if (totalCount > nums.Length / 2)
        {
            return candidate;
        }
        else
        {
            return 0;
        }
    }
}
