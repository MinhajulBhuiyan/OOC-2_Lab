using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09_T02_CSHRP
{
    class Set<T> where T : IComparable<T>
    {
        private T[] elements = new T[100];
        private int count = 0;


        public void Insert(T element)
        {
            if (count < elements.Length)
            {
                if (CheckUnique(element))
                {
                    int index = count;
                    while (index > 0 && elements[index - 1].CompareTo(element) > 0)
                    {
                        elements[index] = elements[index - 1];
                        index--;
                    }
                    elements[index] = element;
                    count++;
                }
            }
        }


        private bool CheckUnique(T element)
        {
            for (int i = 0; i < count; i++)
            {
                if (elements[i].Equals(element))
                {
                    return false;
                }                
            }
            return true;
        }


        public void Delete(T element)
        {
            for (int i = 0; i < count; i++)
            {
                if (elements[i].CompareTo(element) == 0)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        elements[j] = elements[j + 1];
                    }
                    count--;
                }
            }
        }


        public bool Find(T element)
        {
            for (int i = 0; i < count; i++)
            {
                if (elements[i].CompareTo(element) == 0)
                {
                    return true; 
                }
            }
            return false; 
        }


        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(elements[i]);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Set<int> intSet = new Set<int>();

            intSet.Insert(3);
            intSet.Insert(1);
            intSet.Insert(2);
            intSet.Insert(1);
            intSet.Insert(1);
            intSet.Insert(4);
            //intSet.Insert("Bd");

            Console.WriteLine("Integer Set:");
            intSet.Print();

            intSet.Delete(4);
            intSet.Delete(5);


            Console.WriteLine("\nInteger Set:");
            intSet.Print();

            Console.ReadLine();



        }
    }
}
