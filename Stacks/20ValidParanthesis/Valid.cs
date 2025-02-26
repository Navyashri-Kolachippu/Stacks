using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                else
                {
                    if (stack.Count > 0)
                    {
                        char c1 = stack.Pop();
                        char c2 = dict.FirstOrDefault(x => x.Value == c).Key;
                        if (c1 != c2)
                        {
                            return flag;
                        }
                    }
                }

            }
            if (stack.Count == 0) flag = true;
            return flag;

        }
        
    }
}