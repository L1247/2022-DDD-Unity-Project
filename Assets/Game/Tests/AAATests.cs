#region

using Game.Project.Scripts;
using NUnit.Framework;

#endregion

namespace Game.Tests
{
    public class AAATests
    {
    #region Test Methods

        [Test]
        public void B()
        {
            var a      = new A();
            var result = a.B();
            Assert.AreEqual(1 , result , "result is not equal");
        }

    #endregion
    }
}