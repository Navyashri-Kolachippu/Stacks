using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks.Asteroid
{
    public class Asteroid
    {
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
    }
}
