//problem: https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/?envType=study-plan-v2&envId=top-interview-150

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {

        if (nums.Length < 3)
        {
            return nums.Length;
        }

        int slow = 2;
        for (int fast = 2; fast < nums.Length; fast++)
        {
            if (nums[fast] != nums[slow - 2])
            {
                nums[slow] = nums[fast];
                slow++;
            }
        }

        return slow;
    }
}