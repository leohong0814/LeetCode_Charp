public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int tmp = nums[0];
        int count = 1;
        int tmpIndex = 1;
        for(int i = 1;i< nums.Length;i++)
        {
            if(tmp != nums[i])
            {
                count++;
                nums[tmpIndex] = nums[i];
                tmp = nums[i];
                tmpIndex++;
            }
        }
        return count;
    }
}