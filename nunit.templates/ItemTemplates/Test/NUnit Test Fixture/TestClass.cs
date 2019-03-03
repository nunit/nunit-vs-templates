// NUnit3 Tests,  see documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation 
using NUnit.Framework;

namespace $rootnamespace$
{
    [TestFixture]
    public class $safeitemname$
    {
        [Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            var answer = 42;
            Assert.That(answer,Is.EqualTo(42),"Some useful error message");
        }
    }
}
