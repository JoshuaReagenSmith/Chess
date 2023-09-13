using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class BoardMechanics
    {

        public bool CheckSqaure(int i, int k)
        {
            if (i % 2 != 0 && k % 2 != 0) { return false; }//Odd row
            else if (k % 2 == 0 && i % 2 == 0) { return false; }//even row

            return true;
        }
    }
}
