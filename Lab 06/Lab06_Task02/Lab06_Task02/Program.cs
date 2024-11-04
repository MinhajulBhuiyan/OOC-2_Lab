using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Task02
{
    public class MinStack
    {
        private Stack<int> minStack;

        public MinStack()
        { 
            minStack = new Stack<int>();
        }

        public void Push(int val)
        {
            if (minStack.Count == 0 || val <= minStack.Peek())
            {
                minStack.Push(val);
            }
        }

        public void Pop()
        {           
            minStack.Pop();
             
        }

        public int Min()
        {
            if (minStack.Count > 0)
            {
                return minStack.Peek();
            }
            else
            {
                return -1;
            }
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }
}
