using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.OOP.ITI
{
     class Human : Creature
    {
        public int ID;
        public int lenght;
        public Human() : base()
        {

        }
        public Human(int id , int _age) : base(_age) // Excute Creature(int age)
        {
            ID = id;
        }
        public Human(int id, int _age, int x) 
        {

        }

        public void Think()
        {
            Name = "";
            this.Name = "";
            //hidden Member var
            base.Name = "";
            Weight = 0;
            base.Weight = 5;


            Move();
        }
    }
}
