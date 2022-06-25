public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int minLenth = strs[0].Length;
        int minLenthIndex = 0;
        for(int i = 0; i<strs.Length;i++)
            if(strs[i].Length < minLenth)
            {
                minLenth = strs[i].Length;
                minLenthIndex = i;
            } 
        string result = string.Empty;

        for(int i = 0;i<strs[minLenthIndex].Length;i++)
        {
            char spec = strs[minLenthIndex][i];
            bool check = true;
            for(int j = 0; j<strs.Length;j++)
            {
                check&=(strs[j][i]==spec);
            }
            if(check) result+=strs[0][i];
            else break;
        }
        return result;
    }
}