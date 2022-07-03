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
    public bool IsSymmetric(TreeNode root) {
        bool result = true;
        if(root.left ==null && root.right ==null) return true;
        if(root.left !=null && root.right ==null) return false;
        if(root.left ==null && root.right !=null) return false;
        check(ref result, ref root.left, ref root.right);
        return result;
    }
    void check(ref bool result, ref TreeNode p, ref TreeNode q)
    {
        if((p.left!=null &&q.right==null) ||(p.left==null&& q.right!=null)) result&=false;
        if(p.left!= null && q.right!= null)check(ref result,ref p.left, ref q.right);    
        result&= (p.val==q.val);
        if((p.right!=null &&q.left==null) ||(p.right==null&& q.left!=null)) result&=false;
        if(p.right!= null && q.left!= null)check(ref result, ref p.right,ref q.left);
    }
}