using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Y_OOP_2324_StaticAndInstancing
{
    internal class SampleClassA
    {
        private int x = 0;
        public static int y = 0;

        public int getX()
        {
            return x + y;
        }

        public void setX(int a) 
        {
            x = a;
        }
    }
}
