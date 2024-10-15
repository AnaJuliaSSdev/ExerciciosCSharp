1.
public class Solution 
{
    public string LongestCommonPrefix(string[] strs) 
    {
        Array.Sort(strs);
        
        StringBuilder sb = new StringBuilder();
        
        string first = strs[0];
        string last = strs[strs.Length - 1];
        
        for (int i = 0; i < Math.Min(first.Length, last.Length); i++)
        {
            if (first[i] != last[i])
            {
                return sb.ToString();
            }
            sb.Append(first[i]);
        }
        
        return sb.ToString();
    }
}

2. 
//Stack 
//com dicionário
public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        var matchingBrackets = new Dictionary<char, char> {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

        foreach (char ch in s) {
            if (matchingBrackets.ContainsValue(ch)) {
                stack.Push(ch);
            } else if (matchingBrackets.ContainsKey(ch)) {
                if (stack.Count == 0 || stack.Pop() != matchingBrackets[ch]) {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}


//Stack
//sem dicionario
public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        char[] chars = s.ToCharArray();

        foreach(char ch in chars) {
            if(ch == ')') {
                if(stack.Count == 0 || stack.Pop() != '(') return false;
            }
            else if (ch == ']') {
                if(stack.Count == 0 || stack.Pop() != '[') return false;
            }
            else if (ch == '}') {
                if(stack.Count == 0 || stack.Pop() != '{') return false;
            }
            else {
                stack.Push(ch);
            }
        }
        return stack.Count == 0;
    }
}


3. 
public class Solution {
    public int[] PlusOne(int[] digits) {
       for(int i = digits.Length - 1; i >= 0; i--) {
           if (digits[i] == 9) {
               digits[i] = 0;
           } else {
               digits[i]++;
               return digits;
           }
       } 
       int[] firstOne = new int[] { 1 };
       return firstOne.Concat(digits).ToArray();
    }
}
