using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTest
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job testJob1 = new Job();
            Job testJob2 = new Job();

            Assert.IsFalse(testJob1 == testJob2);

        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            var employer = new Employer { Value = "Acme" };
            var employerLocation = new Location { Value = "Desert" };
            var jobType = new PositionType { Value = "Quality Control"};
            var jobCoreCompetency = new CoreCompetency { Value = "Persistence" };

            Job testJob3 = new Job("Product Tester", employer, employerLocation, jobType, jobCoreCompetency);

            Assert.IsTrue(testJob3.EmployerName.Value == "Acme");
            Assert.IsTrue(testJob3.EmployerLocation.Value == "Desert");
            Assert.IsTrue(testJob3.JobType.Value == "Quality Control");
            Assert.IsTrue(testJob3.JobCoreCompetency.Value == "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            var employer = new Employer { Value = "Acme" };
            var employerLocation = new Location { Value = "Desert" };
            var jobType = new PositionType { Value = "Quality Control" };
            var jobCoreCompetency = new CoreCompetency { Value = "Persistence" };

            Job testJob4 = new Job("Product Tester", employer, employerLocation, jobType, jobCoreCompetency);
            Job testJob5 = new Job("Product Tester", employer, employerLocation, jobType, jobCoreCompetency);

            Assert.IsFalse(testJob4.Id == testJob5.Id);
        }
    }
}
