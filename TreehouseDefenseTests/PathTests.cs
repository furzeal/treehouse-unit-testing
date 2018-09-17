using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreehouseDefense;

namespace TreehouseDefenseTests
{
    [TestClass()]
    public class PathTests
    {
        private Map _map3x3;
        private MapLocation[] _pathLocations3;
        private Path _path3;

        [TestCleanup]
        public void testClean()
        {
            _map3x3 = null;
            _pathLocations3 = null;
            _path3 = null;
        }

        [TestInitialize]
        public void testInit()
        {
            _map3x3 = new Map(3, 3);
            _pathLocations3 = new MapLocation[]
            {
                new MapLocation(0, 1, _map3x3),
                new MapLocation(1, 1, _map3x3),
                new MapLocation(2, 1, _map3x3),
            };

            _path3 = new Path(_pathLocations3);
        }

        [TestMethod]
        public void MapLocationIsOnPath()
        {
            
            var target = _path3;

            Assert.IsTrue(target.IsOnPath(new MapLocation(0, 1, _map3x3)));
        }

        [TestMethod]
        public void MapLocationIsNotOnPath()
        {
            var target = _path3;

            Assert.IsFalse(target.IsOnPath(new MapLocation(0, 0, _map3x3)));
        }
    }
}
