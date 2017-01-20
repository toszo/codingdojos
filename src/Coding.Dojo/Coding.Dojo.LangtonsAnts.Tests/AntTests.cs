using Coding.Dojo.LangtonsAnt;
using NUnit.Framework;

namespace Coding.Dojo.LangtonsAnts.Tests
{
    [TestFixture]
    public class AntTests
    {
        [TestCase(Direction.North, Direction.West)]
        [TestCase(Direction.West, Direction.South)]
        [TestCase(Direction.South, Direction.East)]
        [TestCase(Direction.East, Direction.North)]
        public void when_ant_is_on_white_field_than_turns_left(Direction initial, Direction expected)
        {
            var ant = new Ant(initial);
            ant.Move(Color.White);

            var actual = ant.Direction;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(Direction.North, Direction.East)]
        [TestCase(Direction.East, Direction.South)]
        [TestCase(Direction.South, Direction.West)]
        [TestCase(Direction.West, Direction.North)]
        public void when_ant_is_on_black_field_than_turns_right(Direction initial, Direction expected)
        {
            var ant = new Ant(initial);
            ant.Move(Color.Black);

            var actual = ant.Direction;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ant_is_on_zero_zero_point()
        {
            var ant = new Ant();
            Assert.That(ant.CurrentPosition, Is.EqualTo(new Field(0, 0)));
        }

        [Test]
        public void ant_change_color_field()
        {
            var ant = new Ant();

            ant.Move(Color.White);

            Assert.That(ant.CurrentPosition.Color, Is.EqualTo(Color.Black));
        }
    }
}
