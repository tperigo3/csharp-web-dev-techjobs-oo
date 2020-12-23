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
            Job testJob3 = new Job("Product Tester", "Acme", "Desert", "Quality Control", "Persistence" )
            
                


        }
    }
}
