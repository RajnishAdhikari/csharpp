using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    internal class ItalianChef : chef
    {
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes chicken parm");
        }
        public void MakePasta()
        {
            Console.WriteLine("The chef makes pasta");
        }

    }
}
