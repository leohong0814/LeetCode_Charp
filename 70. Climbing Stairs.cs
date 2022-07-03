public class Solution {
    public int ClimbStairs(int n) {
        if(n == 1)
            return 1;
        else if(n==2)
            return 2;
        int present  = 1;
        int current = 2;
        int count = 0;
        for(int i = 3; i<=n ;i++)
        {
            count = present+current;
            present = current;
            current = count;
        }
        return count;
    }
}