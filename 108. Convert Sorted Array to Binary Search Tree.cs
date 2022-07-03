/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode SortedArrayToBST(int[] nums) {
        if (nums == null || nums.Length == 0)
            return null;
        
        return BuildTree(nums, 0, nums.Length - 1);
    }
    
    private TreeNode BuildTree(int[] nums, int startIndex, int endIndex)
    {
        if (endIndex < startIndex)
            return null;
        
        int mid = endIndex + (startIndex - endIndex) / 2;
        TreeNode node = new TreeNode(nums[mid]);
        
        node.left = BuildTree(nums, startIndex, mid - 1);
        node.right = BuildTree(nums, mid + 1, endIndex);
        
        return node;
    }
}