using Microsoft.VisualStudio.TestPlatform.TestHost;
using Project;
namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int a = 3;
            Assert.AreEqual(Project.Program.Func(a), 6);
        }
        [Test]
        public void Test2()
        {
            int b = 10;
            Assert.AreEqual(Project.Program.Func(b), 90);
        }
        [Test]
        public void Test3()
        {
            int c = 5;
            Assert.AreEqual(Project.Program.Func(c), 20);
        }
    }
}