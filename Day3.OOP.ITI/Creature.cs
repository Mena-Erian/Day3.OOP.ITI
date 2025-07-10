using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.OOP.ITI
{
    class Creature
    {
        public string Name;
        protected int Weight; // like public that we can use it in Child that inhernt
        //                       like Private thet we can't use it when create instance from Class Creature
        private int Age;
        public Creature()
        {

        }
        public Creature(int age)
        {
            Age = age;
        }


        public void Move()
        {
            Console.WriteLine("Creature is Moving...");
        }
        public void Eat()
        {
            Console.WriteLine("Creature is eating...");
        }
    }

}
