using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetEx
{
    class Program
    {
        static void Main(string[] args) 
        { 
            Student s=new Student("Tommy","Male");
            Console.WriteLine(s.Gender); 
            Console.WriteLine(s.name);
        }
    }
}
