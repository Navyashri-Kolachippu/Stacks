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

        public int[] AsteroidCollision(int[] asteroids)
        {
            Stack<int> stack = new Stack<int>();
            foreach (int asteroid in asteroids)
            {
                if (asteroid > 0)
                    stack.Push(asteroid);
                else
                {
                    while (stack.Count > 0 && stack.Peek() > 0 && stack.Peek() < Math.Abs(asteroid))
                    {
                        stack.Pop();
                    }
                    if (stack.Count > 0 && stack.Peek() == Math.Abs(asteroid))
                    {
                        stack.Pop();
                    }
                    else if (stack.Count == 0 || stack.Peek() < 0)
                    {
                        stack.Push(asteroid);
                    }
                }

            }
            return stack.Reverse().ToArray();

        }

        public bool UniqueOccurrences(int[] arr)
        {
            bool flag = false;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i=0;i<arr.Length;i++)
            {
                if(dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]]++;
                }
                else
                {
                    dict.Add(arr[i], 1);
                }
            }

            HashSet<int> uniqueValues = new HashSet<int>(dict.Values);

            flag = uniqueValues.Count()==dict.Count();

            return flag;
        }

        public void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;
            int[] temp = nums.Skip(nums.Length-k).ToArray();
            for (int i = k; i >=0; i--)
            {
                nums[k+i] = nums[i];
            }
         
            for (int i = 0; i < temp.Length; i++)
            {
                nums[i] = temp[i];
            }

            //k = k % nums.Length;           
            //Array.Reverse(nums,nums.Length-k, k);
            //Array.Reverse(nums, 0, nums.Length-k);
            //Array.Reverse(nums);
        }
    }
}