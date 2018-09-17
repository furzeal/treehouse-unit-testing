using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreehouseDefense;

namespace TreehouseDefenseTests
{
    [TestClass()]
    public class MapTests
    {
        [TestMethod()]
        public void MapTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void OnMapTest()
        {

            var x = 10;
            var y = 12;
            var width = 13;
            var height = 14;

            var point = new Point(x, y);
            var map = new Map(width, height);

            Assert.IsTrue(map.OnMap(point), "Point should be on map");

        }
    }
}