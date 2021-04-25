using System;
using System.Collections.Generic;
using System.Text;

namespace EntityCreateBusinessObjectTest
{
    public class User
    {
        public Guid Id { get; }
        public Name Name { get; private set; }

        private User() { }

        public User(Name name)
        {
            //Id = new UserId(Guid.NewGuid());
            Id = Guid.NewGuid();
            Name = name ?? throw new ArgumentException("Name must not be null");
        }

        internal void ChangeName(string firstName, string lastName)
        {
            Name = new Name(firstName, lastName);
        }
    }
}
