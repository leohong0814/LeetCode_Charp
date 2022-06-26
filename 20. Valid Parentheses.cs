public class Solution {
        public bool IsValid(string s)
        {
            if ((s.Length % 2) != 0)
                return false;
            int index = 0;
            List<char> targetString = new List<char>();
            while(index < s.Length)
            {
                if (isFrontBracket(s[index]))
                {
                    switch (s[index])
                    {

                        case '{':
                            targetString.Add('}');
                            break;
                        case '[':
                            targetString.Add(']');
                            break;
                        case '(':
                            targetString.Add(')');
                            break;
                    }
                    index++;
                }
                else
                {
                    if(targetString.Count<1) return false;
                    if(targetString.Count>1)
                    {
                        if (s[index] == targetString[targetString.Count-1])
                        {
                            index++;
                            targetString.RemoveAt(targetString.Count - 1);
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (s[index] == targetString[0])
                        {
                            index++;
                            targetString.RemoveAt(0);
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            if(targetString.Count!=0)
                return false;
            return true;
        }
        public bool isFrontBracket(char c)
        {
            switch(c)
            {
                case '{':
                case '[':
                case '(':
                    return true;
                default : 
                    return false;
            }
        }
}