using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTest
{
    [TestClass]
    public class JobTests
    {
        Job job3;
        Job job4;
        
        [TestInitialize]
        public void CreateJobObjects()
        {
            job3 = new Job("Product Tester", new Employer ("Acme"), new Location("Desert"), new PositionType ("Quality Control"), new CoreCompetency ("Persistence"));
            job4 = new Job("Product Tester", new Employer("Acme"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
        }
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
           
            Assert.IsTrue(job3.EmployerName.Value == "Acme");
            Assert.IsTrue(job3.EmployerLocation.Value == "Desert");
            Assert.IsTrue(job3.JobType.Value == "Quality Control");
            Assert.IsTrue(job3.JobCoreCompetency.Value == "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job3.Id == job4.Id);
        }

        [TestMethod]
        public void TestForToString()
        {
                       
            string testString = job3.ToString();
            char firstChar = testString[0];
            char lastChar = testString[testString.Length - 1];

            Assert.IsTrue(firstChar == lastChar);
        }
        
        [TestMethod]
        public void TestForLabelsandData()
        {
            var testSetup = $"\nID: {job3.Id}\nName: {job3.Name}\nEmployer: {job3.EmployerName.Value}\n Location: {job3.EmployerLocation.Value}\n Position: {job3.JobType.Value}\n Core Competency: {job3.JobCoreCompetency.Value}\n";
            
            Assert.AreEqual(testSetup, job3.ToString());
        }
        [TestMethod]
        public void TestToStringEmptyField()
        {
            job3.EmployerName.Value = "";
            job3.EmployerLocation.Value = "";
            string testOutput = $"\nID: {job3.Id}\nName: {job3.Name}\nEmployer: Data not available\n Location: Data not available\n Position: {job3.JobType.Value}\n Core Competency: {job3.JobCoreCompetency.Value}\n";

            Assert.AreEqual(testOutput, job3.ToString());
        }
    }
}
