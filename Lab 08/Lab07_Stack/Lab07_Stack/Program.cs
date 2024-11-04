using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab07_Stack
{
    public class GenericMaxStack<T> where T : IComparable<T>
    {
        private Stack<T> dataStack = new Stack<T>();
        private Stack<T> maxStack = new Stack<T>();

        public void Push(T item)
        {
            dataStack.Push(item); 
            if (maxStack.Count == 0 || item.CompareTo(maxStack.Peek()) >= 0)
            {
                maxStack.Push(item);
            }
                    
        }

        public T Pop()
        {
            if (dataStack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T poppedItem = dataStack.Pop();

            if (poppedItem.CompareTo(maxStack.Peek()) == 0)
            {
                maxStack.Pop();
            }

            return poppedItem;
        }



        public T Max()
        {
            if (maxStack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return maxStack.Peek();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}



