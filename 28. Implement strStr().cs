public class Solution {
    public int StrStr(string haystack, string needle) {

        for(int i=0;i<haystack.Length-needle.Length+1;i++)
        {
            int count = 0;
            do
            {
                if(haystack[i+count] == needle[count])
                    count++;
                else
                    break;
                
            }while(count != needle.Length);
            if(count == needle.Length)
                return i;
        }
        return -1;
    }
}