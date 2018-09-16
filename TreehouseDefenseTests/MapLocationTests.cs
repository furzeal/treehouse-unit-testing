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