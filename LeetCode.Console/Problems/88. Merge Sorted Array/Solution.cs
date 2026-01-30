namespace LeetCode.Console.Problems._88._Merge_Sorted_Array;

public class Solution {
    
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        --m;
        --n;
        for (var i = nums1.Length-1; i >= 0; --i)
        {
            if(m<0)
            {
                nums1[i] = nums2[n];
                --n;

                continue;
            }

            if (n < 0)
            {
                nums1[i] = nums1[m];
                --m;
                continue;
            }
            
            if (nums1[m] > nums2[n])
            {
                nums1[i] = nums1[m];
                --m;
            }
            else
            {
                nums1[i] = nums2[n];
                --n;
            }
        }
    }
}