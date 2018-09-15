using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreehouseDefense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense.Tests
{
    [TestClass()]
    public class PointTests
    {
        [TestMethod()]
        public void PointTest()
        {
            var x = 5;
            var y = 6;

            var point = new Point(x,y);

            Assert.AreEqual(x,point.X);
            Assert.AreEqual(y,point.Y);
        }

        [TestMethod()]
        public void DistanceToTest()
        {
           Assert.Fail();
        }
    }
}