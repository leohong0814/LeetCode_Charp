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
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        if(root ==null) return result;
        visit(ref result, root);
        return result;
    }
    void visit(ref List<int> resutl, TreeNode node)
    {        
        if (node.left  != null)visit(ref resutl, node.left);
        resutl.Add(node.val);
        if (node.right != null)visit(ref resutl, node.right);  
    }
}