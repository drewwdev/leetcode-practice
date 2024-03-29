// https://leetcode.com/problems/merge-sorted-array/submissions/?envType=study-plan-v2&envId=top-interview-150

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int pointer1 = m - 1;
        int pointer2 = n - 1;
        int mergedPointer = m + n - 1;

        while (pointer1 >= 0 && pointer2 >= 0)
        {
            if (nums1[pointer1] >= nums2[pointer2])
            {
                nums1[mergedPointer] = nums1[pointer1];
                pointer1--;
            }
            else
            {
                nums1[mergedPointer] = nums2[pointer2];
                pointer2--;
            }
            mergedPointer--;
        }

        while (pointer2 >= 0)
        {
            nums1[mergedPointer] = nums2[pointer2];
            pointer2--;
            mergedPointer--;
        }
    }
}
