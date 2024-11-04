using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Task2
{
    public class MinMaxStack<T> where T : IComparable<T>
    {
        private Stack<T> dataStack;
        private Stack<T> minStack;
        private Stack<T> maxStack;
        private string condition;

        public MinMaxStack(string condition)
        {
            dataStack = new Stack<T>();
            minStack = new Stack<T>();
            maxStack = new Stack<T>();

            if (condition.ToLower() != "min" && condition.ToLower() != "max")
            {
                throw new ArgumentException("Invalid condition. Use 'min' or 'max'.");
            }

            this.condition = condition;
        }

        public void Push(T item)
        {
            dataStack.Push(item);

            if (minStack.Count == 0 || item.CompareTo(minStack.Peek()) <= 0)
            {
                minStack.Push(item);
            }

            if (maxStack.Count == 0 || item.CompareTo(maxStack.Peek()) >= 0)
            {
                maxStack.Push(item);
            }
        }

        public T Pop()
        {
            if (dataStack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            T poppedItem = dataStack.Pop();

            if (poppedItem.Equals(minStack.Peek()))
            {
                minStack.Pop();
            }

            if (poppedItem.Equals(maxStack.Peek()))
            {
                maxStack.Pop();
            }

            return poppedItem;
        }

        public T Aggregate()
        {
            if (dataStack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            if (condition.ToLower() == "min")
            {
                return minStack.Peek();
            }
            else
            {
                return maxStack.Peek();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MinMaxStack<int> minStack = new MinMaxStack<int>("min");
            minStack.Push(3);
            minStack.Push(2);
            minStack.Push(5);

            int min = minStack.Aggregate();
            Console.WriteLine($"Min: {min}");

            MinMaxStack<int> maxStack = new MinMaxStack<int>("max");
            maxStack.Push(3);
            maxStack.Push(2);
            maxStack.Push(5);

            int max = maxStack.Aggregate();
            Console.WriteLine($"Max: {max}");
            Console.ReadKey();
        }
    }
}


