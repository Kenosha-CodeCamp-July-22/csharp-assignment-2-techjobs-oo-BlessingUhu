using System;

namespace TechJobsOO
{
    public abstract class JobField
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public JobField()
        {
            Id = nextId;
            nextId++;
        }

        public JobField(string value) : this()
        {
            Value = value;
        }


        public abstract bool Equals(object obj);


        public abstract int GetHashCode();

        public abstract string ToString();

    }


}
