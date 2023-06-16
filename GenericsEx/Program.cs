using System;
namespace GenericsEx
{
    class StringDataBase
    {
        public List<string> Items = new List<string>();
        public void Create(string item)
        {
            Items.Add(item);
        }
        public void Remove(string item)
        {
            Items.Remove(item);
        }
        public void Display()
        {
            Console.WriteLine("List of Strings");
            Items.ForEach(x =>
            {
                Console.WriteLine(x);
            });
        }
    }
    class IntDataBase
    {
        public List<int> Items = new List<int>();
        public void Create(int item)
        {
            Items.Add(item);
        }
        public void Remove(int item)
        {
            Items.Remove(item);
        }

        public void Display()
        {
            Console.WriteLine("List of Integers");
            Items.ForEach(x =>
            {
                Console.WriteLine(x);
            });
        }
    }

    class GenericDataBase<T>
    {
        public List<T> Items = new List<T>();
        public void Create(T item)
        {
            Items.Add(item);
        }
        public void Remove(T item)
        {
            Items.Remove(item);
        }

        public void Display()
        {
            Console.WriteLine("List of"+typeof(T).Name +"'s");
            Items.ForEach(x =>
            {
                Console.WriteLine(x);
            });
        }
    }
}
























//Helps to decouple logic and data types
//Code re usability.
//Create the logic in a very "Generic data type" then later
//apply it to many data types.



