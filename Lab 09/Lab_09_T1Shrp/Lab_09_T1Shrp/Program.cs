using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09_T1Shrp
{
    class Set<T>
    {
        private T[] elements = new T[100];
        private int count = 0;

        public void Insert(T element)
        {
            if (count < elements.Length)
            {
                elements[count] = element;
                count++;
            }
        }

        public void Delete(T element)
        {
            for (int i = 0; i < count; i++)
            {
                if (elements[i].Equals(element))
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        elements[j] = elements[j + 1];
                    }
                    count--;
                    return;
                }
            }
        }

        public bool Find(T element)
        {
            for (int i = 0; i < count; i++)
            {
                if (elements[i].Equals(element))
                {
                    return true; 
                }
            }
            return false; 
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Set<string> stringSet = new Set<string>();
            Set<int> intSet = new Set<int>();

            stringSet.Insert("Apple");
            stringSet.Insert("Samsung");
            stringSet.Insert("OnePlus");
            stringSet.Insert("Mi");

            intSet.Insert(1);
            intSet.Insert(2);
            intSet.Insert(3);

            bool foundString1 = stringSet.Find("Samsung");
            bool foundString2 = stringSet.Find("Mi");
            bool foundInt = intSet.Find(2);

            Console.WriteLine("String Set:");
            Console.WriteLine("Found in String Set: " + foundString1);
            Console.WriteLine("Found in String Set: " + foundString2);

            stringSet.Delete("Mi");
            bool foundString3 = stringSet.Find("Mi");

            Console.WriteLine("Found in String Set: " + foundString3);


            Console.WriteLine("\nInteger Set:");
            Console.WriteLine("Found in Integer Set: " + foundInt);

            
            //intSet.Insert("Vivo");
            Console.ReadLine();
        }
    }
}


