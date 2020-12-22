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

            Assert.IsTrue(testJob1 == testJob2);

        }
    }
}
