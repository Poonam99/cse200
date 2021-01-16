using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class cricket
    {
        public string name;
        public int wickets;
        public int overs;
        public void Show()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("wickets in a match: " + wickets);
            Console.WriteLine("overs: " + overs);
            Console.WriteLine("");
            Console.WriteLine("");
        }

    }
}