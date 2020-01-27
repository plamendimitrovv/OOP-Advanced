using System;
using System.Collections.Generic;
using System.Text;

namespace _6.StrategyPattern
{
    public class PersonNameComparer : IComparer<Person>
    {
        public int Compare(Person firstPerson, Person secondPerson)
        {
            
            int result = firstPerson.Name.Length.CompareTo(secondPerson.Name.Length);

            if (result == 0)
            {
                char firstPersonLetter = char.ToLower(firstPerson.Name[0]);
                char secondPersonLetter = char.ToLower(secondPerson.Name[0]); 

                result = char.ToLower(firstPersonLetter).CompareTo(char.ToLower(secondPersonLetter)); 

            }

            return result; 
        }
    }
}
