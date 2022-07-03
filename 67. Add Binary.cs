public class Solution {
    public string AddBinary(string a, string b) {
        if(a.Length > b.Length)
        {
            int diffLength = a.Length - b.Length;
            for(int i= 0; i<diffLength ;i++)
                b = '0'+b;
        }
        else if(a.Length < b.Length)
        {
            int diffLength = b.Length - a.Length;
            for(int i= 0; i<diffLength ;i++)
                a = '0'+a;
        }
        string result = "";
        int carry = 0;
        for(int i = a.Length-1;i>=0;i--)
        {
            int aInt = (a[i]=='1')?1:0;
            int bInt = (b[i]=='1')?1:0;
            if(aInt+bInt+carry >=2)
            {        
                result = (aInt+bInt+carry-2).ToString() + result;
                carry = 1;
            }
            else
            {
                result = (aInt+bInt+carry).ToString() + result;
                carry = 0;
            }
        }
        if(carry ==1)
            result = '1'+result;
        return result;
    }
}