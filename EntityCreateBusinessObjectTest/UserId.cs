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

        public override int GetHashCode() => Value.GetHashCode();
        public override bool Equals(object obj) => obj is UserId other && Value == other.Value;
    }
}