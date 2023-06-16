using System.Transactions;

namespace DecisionMakingEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int age=Console.ReadLine();
            
            if(age>18)
            {
                Console.WriteLine("You can apply for driving License");
            }else
            {
                Console.WriteLine("You can't apply");
            }
        }
    }
}