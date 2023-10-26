using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Y_OOP_2324_StaticAndInstancing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SampleClassA sca = new SampleClassA();
            SampleClassA scb = new SampleClassA();
            SampleClassA scc = new SampleClassA();
            SampleClassA scd = new SampleClassA();
            SampleClassA sce = new SampleClassA();

            //Console.WriteLine(sca.getX());

            //sca.setX(9);

            SampleClassA.y = 10;

            Console.WriteLine(sca.getX());
            Console.WriteLine(scb.getX());
            Console.WriteLine(scc.getX());
            Console.WriteLine(scd.getX());
            Console.WriteLine(sce.getX());

            Console.WriteLine(StaticClassA.x.ToString());
            //Console.WriteLine(SampleClassA.y.ToString());

            SampleClassB scf = new SampleClassB();
            SampleClassB scg = new SampleClassB(5);
            SampleClassB sch = new SampleClassB(5, 6);

            Console.ReadKey();
        }
    }
}
