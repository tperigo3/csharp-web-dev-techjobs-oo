using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; private set;  }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        private void SetId()
        {
            Id = nextId;
            nextId++;
        }
        public Job()
        {
            SetId();
        }
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency)
        {
            SetId();
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string infoToString;
            if (Name == "")
            {
                Name = "Data not available";
            }
            if (EmployerName.Value == "")
            {
                EmployerName.Value = "Data not available";
            }
            if (EmployerLocation.Value == "")
            {
                EmployerLocation.Value = "Data not available";
            }
            if (JobType.Value == "")
            {
                JobType.Value = "Data not available";
            }
            if (JobCoreCompetency.Value == "")
            {
                JobCoreCompetency.Value = "Data not available";
            }
            infoToString = $"\nID: {Id}\nName: {Name}\nEmployer: {EmployerName.Value}\n Location: {EmployerLocation.Value}\n Position: {JobType.Value}\n Core Competency: {JobCoreCompetency.Value}\n";
            return infoToString;
        }

    }
}

