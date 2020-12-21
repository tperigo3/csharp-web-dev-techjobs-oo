using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechJobsTest
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
       {
            string testJob1 = new Job();
            string testJob2 = new Job();

            Assert.IsTrue(testJob1 == testJob2);

        }
    }
}
