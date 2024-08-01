using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackArray
{
    public class StackArray
    {
        int top,popindex;
        List<int> stack = new List<int>();
        List<int> pops = new List<int>();

        public void Push(int num)
        {
            stack.Add(num);
            top++;
        }
        public void Pop(int index)
        {
            if (stack.Count > 0)
            {
                pops.Add(stack[index]);
                stack.RemoveAt(index);
                top--;
            }
            else
            {
                stack.Add(-1);
            }
        }

        public List<int> PrintPop(int[] nums)
        {
            for(int i=0; i < nums.Length;i++)
            {
                int index = top > 0 ? top - 1 : 0;

                if(stack.Count > 0)
                    if (stack[index] == nums[i]) continue;

                if (nums[i] % 2 == 0)
                {
                    Pop(index);
                }
                else if(nums[i] % 1 == 0)
                {
                    Push(nums[i + 1]);
                }
            }

            return pops;
        }
    }
}
