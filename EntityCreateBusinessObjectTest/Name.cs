using System;
using System.Collections.Generic;
using System.Text;

namespace EntityCreateBusinessObjectTest
{
    public class Name
    {
        public string First { get; }
        public string Last { get; }

        protected Name() { }

        public Name(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName))
                throw new ArgumentException("FirstName must not be null or empty"); 
            
            if (string.IsNullOrEmpty(lastName))
                throw new ArgumentException("LastName must not be null or empty");


            First = firstName;
            Last = lastName;
        }
    }
}
