using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEx
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            StringDataBase sdb = new StringDataBase();
            sdb.Create("Hello");
            sdb.Create("World");
            sdb.Display();

            IntDataBase idb = new IntDataBase();
            idb.Create(1);
            idb.Create(2);
            idb.Display();

            GenericDataBase<int> gdb = new GenericDataBase<int>();
            gdb.Create(23);
            gdb.Create(33);
            gdb.Display();
            
        }
    }
}
