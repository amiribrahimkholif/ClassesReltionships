﻿using System;
using System.Collections.Generic;

namespace OOP_Review
{
    class Program
    {
        /*
         **Classes Relationships**
         
         1-Association : is a "uses or interacts" relationship between two objects which one of them uses the other ,
            when you make an object a field in the other class . ex :the professor communicates with students, but to these usage is permanent,
            if the relationship is always there so it is association relationship.(represented by Normal arrow).
         
         2-Dependency : is a "uses or interacts" relationship between two objects which one of them uses the other. but the relationship is not permanent,
            ex : an object is used as a method parameter for the other object.(represented by dashed arrow).
        
         3-Composition : is a strong "has a" relationship..the container (Whole) controles the life -meaning- of the component(part),
            the part has no meaning without the whole.(represented by filled Diamond arrow).

         4-Aggregation : is a weak "has a" relationship..the container (Whole) doesn't controle the life -meaning- of the component(part),
            the part has meaning without the whole or can be without the whole.(represented by Normal Diamond arrow).
         
         5-Generization (Inheritance): it is "is a" relationship . we use it to achieve Reusability.ex : circle is a shape.(represented by Normal Tringle arrow).
         
         */

        //Association Relationship example.
        class student { };
        class Pofessor
        {
            private List<student> students;
        };

        //Dependency Relationship example.
        class salary { };
        class AccountingEmployee
        {
            public double CalcTax(salary salary){ ... };
        };

        // Composition Relationship example.
        class Engine{ };
        class Wheel { };
        class Car
        {
            private Engine engine;
            private List<Wheel> wheels;
        }

        // Aggregation Relationship example.
        class Professor { };
        class Department
        {
            private Professor professor; //if the department is closed , the professor is still professor.
        }


        // Generlization Relationship example.
        class Shape { ..... };
        class Circle : Shape
        {
            
        }

    }
}
