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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        bool result = true;
        if(p==null && q ==null) return true;
        if((p==null && q!=null) || (p!=null &&q==null)) return false;
        check(ref result, ref p, ref q);
        return result;
    }
    
    void check(ref bool result, ref TreeNode p , ref TreeNode q)
    {
        if(p.left!=null && q.left!=null) check(ref result, ref p.left,ref q.left);
        if(p.left ==null && q.left!=null ||p.left !=null && q.left==null) result &= false;
        result &= (p.val == q.val)?true:false;
        if(p.right!=null && q.right!=null) check(ref result, ref p.right,ref q.right);
        if(p.right ==null && q.right!=null ||p.right !=null && q.right==null) result &= false;
    }
}