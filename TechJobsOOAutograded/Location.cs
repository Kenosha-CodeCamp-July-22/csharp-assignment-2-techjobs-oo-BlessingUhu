using System;
using TechJobsOOAutograded;


namespace TechJobsOO
{
    public class Location : JobField
    {

        //DONE: TEST PASSED
        public Location(string value) : base(value)
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Location location &&
                   Id == location.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }

    }
}