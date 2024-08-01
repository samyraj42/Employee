using System;
using System.Text;

namespace StackArray
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StackArray stack = new StackArray();
            int[] nums = new int[] { 1, 2 ,1 ,3, 2 ,1, 4 ,2 };
            var arrs = stack.PrintPop(nums);
            StringBuilder sb = new StringBuilder();
            foreach(int n in arrs)
            {
                sb.Append(n + ", ");
            }
            Console.Write(sb.ToString());
            Console.ReadLine();
        }
    }
}
