using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.OOP.ITI
{
    class HumanBody
    {
        Head head;
        public HumanBody()
        {
            head = new Head();// composition 
        }

        public void Think()
        {

        }
    }
}
