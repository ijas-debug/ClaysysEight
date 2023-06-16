using System;

namespace ConstructorEx
{
    public class Fruit
    {
        public string color;
        public string name;

        public Fruit(string fruitColor, string fruitName) //constructor
        { 
            color =fruitColor; 
            name = fruitName;
        }
        public void DisplayName()
        {
            Console.WriteLine(name);
        }
        public void DisplayColor()
        {
            Console.WriteLine(color);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fruit apple = new Fruit("Red", "Apple");
            apple.DisplayName();
            apple.DisplayColor();
           
        }
    }
}
