public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        List<int> mergeResult = new List<int>();
        int index1=0 ,index2 = 0;
        
        while(mergeResult.Count != m+n)
        {
            int first = nums1[index1];
            int second =  (index2<n)?nums2[index2]:first;
            if(first<=second && index1<m)
            {
                mergeResult.Add(first);
                index1++;
            }
            else
            {
                mergeResult.Add(second);
                index2++;
            }
        }
        for(int i = 0;i<m+n;i++)
            nums1[i] = mergeResult.ToArray()[i];
    }
}