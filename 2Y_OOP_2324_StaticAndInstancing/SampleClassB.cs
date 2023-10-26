using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Y_OOP_2324_StaticAndInstancing
{
    internal class SampleClassB
    {
        public SampleClassB() 
        {
            Console.WriteLine("This is the generic initialization of the instance");
        }
        public SampleClassB(int x)
        {
            Console.WriteLine($"This instance has a starting number {x}");
        }
        public SampleClassB(int x, int y)
        {
            Console.WriteLine($"This instance has two starting numbers {x} and {y}");
        }
    }
}
