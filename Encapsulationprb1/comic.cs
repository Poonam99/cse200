
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            comic a1 = new comic();
            comic a2 = new comic();
            comic a3 = new comic();
            a1.Setname("There is a way");
            a2.Setname("if there is a will");
            a3.Setname("never give up");
            Console.WriteLine(a1.Getname());
            Console.WriteLine(a2.Getname());
            Console.WriteLine(a3.Getname());
            Console.ReadKey();
        }
    }
}