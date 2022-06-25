public class Solution {
    public bool IsPalindrome(int x) {
        if(x<0)
            return false;
        else
        {
            char[] front = x.ToString().ToCharArray();
            char[] end = x.ToString().ToCharArray();
            for(int i =0; i<front.Length;i++ )
            {
                if(front[i] != end[front.Length -i-1])
                    return false;
            }
            return true;
        }
    }
}