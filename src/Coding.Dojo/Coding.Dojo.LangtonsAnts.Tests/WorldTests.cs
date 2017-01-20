using System.Collections.Generic;
using Coding.Dojo.LangtonsAnt;
using NUnit.Framework;

namespace Coding.Dojo.LangtonsAnts.Tests
{
    [TestFixture]
    public class WorldTests
    {
        [Test]
        public void world_is_initialized_with_zero_zero_point()
        {
            var world = new World();

            Assert.That(world.Fields, Is.EquivalentTo(new List<Field> { new Field(0, 0) }));
        }
        [Test]
        public void ant_is_on_zero_zero_point()
        {
            var world = new World();

            Assert.That(world.Fields, Is.EquivalentTo(new List<Field> { new Field(0, 0) }));
        }
    }
}