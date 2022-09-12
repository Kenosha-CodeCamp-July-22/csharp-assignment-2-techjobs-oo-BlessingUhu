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

        public virtual bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public virtual int GetHashCode()
        {
            return base.GetHashCode();
        }

        public virtual string ToString()
        {
            return base.ToString();
        }
    }


}
