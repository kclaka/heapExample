using System;
using System.Text;

namespace heapExample
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder ref1 = new StringBuilder("object 1");
            Console.WriteLine(ref1);

            StringBuilder ref2 = new StringBuilder("object 2");
            Console.WriteLine(ref2);
            StringBuilder ref3 = ref2;

            Console.WriteLine(ref3);
        }
    }
}
