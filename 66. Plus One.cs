public class Solution {
    public int[] PlusOne(int[] digits) {
        int carrier = 1;
        
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            int temp = digits[i] + carrier;
            
            digits[i] = temp % 10;
            carrier = temp / 10;
        }
        
        if (carrier == 1)
        {
            List<int> temp = new List<int>();
            
            temp.Add(carrier);
            
            foreach (var n in digits)
                temp.Add(n);
            
            return temp.ToArray();
        }
        
        return digits;
    }
}