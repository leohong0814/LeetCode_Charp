public class Solution {
    public int RomanToInt(string s) {
        int index = 0, sum = 0;
        while(index < s.Length)
        {
            if(s[index] == 'I')
            {
                if(index+1 != s.Length)
                {
                    if(s[index+1] =='V')
                    {
                        sum+=4;
                        index+=2;
                    }
                    else if(s[index+1]=='X')
                    {
                        sum+=9;
                        index+=2;
                    }
                    else
                    {
                        sum+=1;
                        index++;
                    }
                }
                else
                {
                    sum+=1;
                    index++;
                }
            }
            else if(s[index] == 'V')
            {
                sum+=5;
                index++;
            }
            else if(s[index] == 'X')
            {
                if(index+1 != s.Length)
                {
                    if(s[index+1] =='L')
                    {
                        sum+=40;
                        index+=2;
                    }
                    else if(s[index+1]=='C')
                    {
                        sum+=90;
                        index+=2;
                    }
                    else
                    {
                        sum+=10;
                        index++;
                    }
                }
                else
                {
                    sum+=10;
                    index++;
                }
            }
            else if(s[index] == 'L')
            {
                sum+=50;
                index++;
            }
            else if(s[index] == 'C')
            {
                if(index+1 != s.Length)
                {
                    if(s[index+1] =='D')
                    {
                        sum+=400;
                        index+=2;
                    }
                    else if(s[index+1]=='M')
                    {
                        sum+=900;
                        index+=2;
                    }
                    else
                    {
                        sum+=100;
                        index++;
                    }
                }
                else
                {
                    sum+=100;
                    index++;
                }
            }
            else if(s[index] == 'D')
            {
                sum+=500;
                index++;
            }
            else if(s[index] == 'M')
            {
                sum+=1000;
                index++;
            }
        }
        return sum;
    }
}