﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.OOP.ITI
{
    class Room
    {
        //Aggregation 
        Instructor instrucotr; // Make Ref of Type Instructor // Ref point to NULL.
        Student[] students; // Make Ref of Array of Students
        int index = 0;

        Wall[] walls;

        public Room()
        {
            instrucotr = null;
            students = new Student[10]; // New Object form Class Array and this object have 10 Ref From Type Student
            //                          Array of Refrences and Each Ref Point to NULL.
            walls = new Wall[4]; // Still i don't now the Relation
        }
        public void Build()
        {
            for (int i = 0; i < walls.Length; i++)
            {
                walls[i] = new Wall(); // Composition Relation // Becouse the Creation Happeaned in Class Room
            }
        }
        public void InstructorEntered(Instructor ins)
        {
            instrucotr = ins;
        }
        public void InstructorLeft()
        {
            instrucotr = null;
        }
        public void StudentEntered(Student std)
        {
            students[index++] = std;
        }


        public void InstructorTurnLightOn()
        {
            //instrucotr
        }
    }

}
