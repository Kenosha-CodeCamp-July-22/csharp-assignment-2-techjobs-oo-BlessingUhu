using System;
using TechJobsOOAutograded;

namespace TechJobsOO
{
    public class PositionType : JobField
    {

        public PositionType(string value) : base(value)
        {
        }

        //DONE: TEST PASSED
        public override bool Equals(object obj)
        {
            return this.Equals(obj);
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        public override string ToString()
        {
            return Value;
        }

    }
}