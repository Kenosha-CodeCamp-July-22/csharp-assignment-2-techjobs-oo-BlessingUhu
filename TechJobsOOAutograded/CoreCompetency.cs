using System;
//using Newtonsoft.Json.Linq;
using TechJobsOOAutograded;

namespace TechJobsOO
{
    public class CoreCompetency : JobField
    {

        //DONE and TEST PASSED

        public CoreCompetency(string v) : base(v)
        {
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
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