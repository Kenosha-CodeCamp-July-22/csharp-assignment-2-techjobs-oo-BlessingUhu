using System;
using System.Data;
using System.Xml.Linq;

namespace TechJobsOO
{
    public class TechJob : JobField
    { 

        //DONE: CONSTRUCTORS
        

        public TechJob(string value) : base(value)
        {
        }

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        public TechJob(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency)
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }


        //DONE: OVERRIDE METHODS
        public override bool Equals(object obj)
        {
            return obj is TechJob job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string NaN = "Data not available";

            if (Name == null || Name == "")
            {
                Name = NaN;
            }
            else if (EmployerName == null || EmployerName.ToString() == "")
            {
                EmployerName.Value = NaN;
            }
            else if (EmployerLocation == null || EmployerLocation.ToString() == "")
            {
                EmployerLocation.Value = NaN;
            }
            else if (JobType == null || JobType.ToString() == "")
            {
                JobType.Value = NaN;
            }
            else if (JobCoreCompetency == null || JobCoreCompetency.ToString() == "")
            {
                JobCoreCompetency.Value = NaN;
            }

            return "\n" + "ID: " + Id.ToString() + "\n" +
                    "Name: " + Name + "\n" +
                    "Employer: " + EmployerName.ToString() + "\n" +
                    "Location: " + EmployerLocation.ToString() + "\n" +
                    "Position Type: " + JobType.ToString() + "\n" +
                    "Core Competency: " + JobCoreCompetency.ToString() + "\n";

        }

    }
}