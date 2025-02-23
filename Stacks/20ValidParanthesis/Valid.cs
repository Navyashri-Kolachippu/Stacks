using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks._20ValidParanthesis
{
    public class Valid
    {

        public bool IsValid(string s)
        {
            bool flag = false;
            Dictionary<char, char> dict = new Dictionary<char, char>();
            dict.Add('(', ')');
            dict.Add('[', ']');
            dict.Add('{', '}');
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{') stack.Push(c);
                else if (c == ')')
                {
                    if (stack.TryPeek(out char c2) && c2 == '(')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return flag;
                    }
                }
                else if (c == ']')
                {
                    if (stack.TryPeek(out char c2) && c2 == '[')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return flag;
                    }
                }
                else if (c == '}')
                {
                    if (stack.TryPeek(out char c2) && c2 == '{')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return flag;
                    }
                }

            }
            if (stack.Count == 0) flag = true;
            return flag;

        }
    }
}