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
  public int MaxDepth(TreeNode root) {
        if (root == null)
            return 0;
            
        return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
    }
}

/*public class Solution {
    public int MaxDepth(TreeNode root) {
        int depth = 0;
        if(root == null) return 0;
        check(ref depth, 1, ref root);
        return depth;
    }
    
    void check(ref int depth, int currDepth, ref TreeNode node)
    {
        if(currDepth>depth) depth = currDepth;
        if(node.left != null ) check(ref depth, currDepth+1, ref node.left);
        if(node.right != null ) check(ref depth, currDepth+1, ref node.right);
    }
}*/