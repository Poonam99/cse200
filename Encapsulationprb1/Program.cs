using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class comic
    {
        private string comic_name;

        public string Getname()
        {
            return comic_name;
        }
        public void Setname(String comic_name)
        {
            this.comic_name = comic_name;
        }
    }
}