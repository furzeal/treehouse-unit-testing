using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreehouseDefense;
using TreehouseDefenseTests.Mocks;

namespace TreehouseDefenseTests
{
    [TestClass()]
    public class TowerTests
    {
        

        [TestMethod()]
        public void FireOnInvadersDecreasesInvadersHealth()
        {
            var map = new Map(3,3);
            var target = new Tower(new MapLocation(0, 0, map));

            IInvader[] invaders = {
                new InvaderMock() {Location = new MapLocation(0, 0, map)},
                new InvaderMock() {Location = new MapLocation(0, 0, map)},
            };

            target.FireOnInvaders(invaders);

            foreach (var invader in invaders)
                Assert.AreEqual(1, invader.Health);
        }
    }
}