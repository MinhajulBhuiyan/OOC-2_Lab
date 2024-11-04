using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08_Temp
{
    class MyList<T>
    {
        private T[] items;
        private int count;

        public MyList()
        {
            items = new T[10]; 
            count = 0;
        }

        public void AddItem(T item)
        {
            if (count == items.Length)
            {
                Array.Resize(ref items, items.Length * 2);
            }
            items[count] = item;
            count++;
        }

        public T GetItem(int index)
        {
            if (index >= 0 && index < count)
            {
                return items[index];
            }
            throw new IndexOutOfRangeException();
        }

        public T RemoveItem(int index)
        {
            if (index >= 0 && index < count)
            {
                T item = items[index];
                for (int i = index; i < count - 1; i++)
                {
                    items[i] = items[i + 1];
                }
                count--;
                return item;
            }
            throw new IndexOutOfRangeException();
        }

        public int Size()
        {
            return count;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public void Clear()
        {
            items = new T[10];
            count = 0;
        }

        public bool Contains(T item)
        {
            return Array.IndexOf(items, item, 0, count) != -1;
        }

        public T[] ToArray()
        {
            T[] result = new T[count];
            Array.Copy(items, result, count);
            return result;
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }

    class Student : Person
    {
        public string UniversityName { get; set; }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying at {UniversityName}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<Person> myList = new MyList<Person>();

            Person person1 = new Person { Name = "Alice", Address = "123 Main St", Age = 25 };
            Person person2 = new Person { Name = "Bob", Address = "456 Elm St", Age = 30 };
            Person person3 = new Person { Name = "Charlie", Address = "789 Oak St", Age = 22 };

            myList.AddItem(person1);
            myList.AddItem(person2);
            myList.AddItem(person3);

            MyList<Student> studentList = new MyList<Student>();

            Student student1 = new Student { Name = "David", Address = "111 College Ave", Age = 21, UniversityName = "XYZ University" };
            Student student2 = new Student { Name = "Eve", Address = "222 College Ave", Age = 19, UniversityName = "ABC University" };

            studentList.AddItem(student1);
            studentList.AddItem(student2);

            Console.WriteLine("Persons:");
            for (int i = 0; i < myList.Size(); i++)
            {
                Console.WriteLine(myList.GetItem(i).Name);
            }

            Console.WriteLine("\nStudents:");
            for (int i = 0; i < studentList.Size(); i++)
            {
                Console.WriteLine(studentList.GetItem(i).Name);
            }
            Console.ReadLine();
        }
    }
}






