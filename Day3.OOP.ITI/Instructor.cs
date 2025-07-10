using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.OOP.ITI
{
    public class Instructor
    {
        public string Name { get; set; }
        protected string Description { get; set; }
        //                       Association
        public void WriteOnBoard( int num, Marker marker)
        {
            marker = null;
        }
        public void WriteOnBoard()
        {
            Marker marker = new Marker();// Still Association
        }
        public void Attend()
        {

        }
    }
}





