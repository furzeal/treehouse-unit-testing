using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreehouseDefense;

namespace TreehouseDefenseTests
{
    [TestClass()]
    public class MapLocationTests
    {
        [TestMethod()]
        public void ShouldThrowException()
        {
            var map = new Map(3,3);
            var exception = Assert.ThrowsException<OutOfBoundsException>(() => new MapLocation(3,3,map));
        }
    }
}