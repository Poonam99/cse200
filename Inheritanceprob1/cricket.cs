
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
             cricket f1 = new cricket();
             cricket f2 = new cricket();
             cricket f3 = new cricket();
            cricket f4 = new cricket();
            cricket f5 = new cricket();
           
            f1.name = "Mashrafi";
            f2.name = "Tamim";
            f3.name = "Mushfiq";
            f4.name = "Sakib";
            f5.name = "Taskin";
           
            f1.wickets = 25;
            f2.wickets = 10;
            f3.wickets = 20;
            f4.wickets = 30;
            f5.wickets= 16;
           
            f1.overs = 6;
            f2.overs = 10;
            f3.overs = 4;
            f4.overs= 15;
            f5.overs = 7;
           
            f1.Show();
            f2.Show();
            f3.Show();
            f4.Show();
            f5.Show();
           
            Console.ReadLine();
        }
    }
}
