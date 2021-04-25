using System;

namespace EntityCreateBusinessObjectTest
{
    public class UserId
    {
        public Guid Value { get; }
        protected UserId() { }

        public UserId(Guid id)
        {
            if (id == Guid.Empty)
                throw new ArgumentException("UserId must not be Empty");

            Value = id;

        }
    }
}