using BowlingGameTask;
using NUnit.Framework;

namespace BowlingGameTaskTests
{
    public class BowlingGameTests
    {
        private BowlingGame game;

        [SetUp]
        public void Setup()
        {
            game = new BowlingGame();
        }

        [Test]
        public void SpareCalculationTest()
        {
            game.Roll(8);
            game.Roll(2);
            game.Roll(5);
            Assert.AreEqual(20, game.Score());
        }

        [Test]
        public void StrikeCalculationTest()
        {
            game.Roll(10);
            game.Roll(3);
            game.Roll(3);
            Assert.AreEqual(22, game.Score());
        }

        [Test]
        public void MaximumScoreTest()
        {
            for (int i = 0; i < 12; i++)
            {
                game.Roll(10);
            }
            Assert.AreEqual(300, game.Score());
        }

        [Test]
        public void SpareWithRollsArrayCalculationTest()
        {
            game.Roll(new int[] { 7, 3, 2 });
            Assert.AreEqual(14, game.Score());
        }

        [Test]
        public void StrikeWithRollsArrayCalculationTest()
        {
            game.Roll(new int[] { 10, 1, 5 });
            Assert.AreEqual(22, game.Score());
        }

        [Test]
        public void MaximumScoreWithRollsArrayTest()
        {
            game.Roll(new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 });
            Assert.AreEqual(300, game.Score());
        }
        [Test]
        public void OutputStringTest()
        {
            var result = game.OutputString(new string[] { "2, 3", "5, 4", "9, /", "2, 5", "3, 2", "4, 2", "3, 3", "4, /", "X   ", "3, 2   " });
            Assert.AreEqual(result, "|2, 3|5, 4|9, /|2, 5|3, 2|4, 2|3, 3|4, /|X   |3, 2   |");
        }

    }
}