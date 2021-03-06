﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _6.StrategyPattern
{
    public class PersonAgeComparer : IComparer<Person>

    {
        public int Compare(Person firstPerson, Person secondPerson)
        {
            return firstPerson.Age.CompareTo(secondPerson.Age); 
        }
    }
}
