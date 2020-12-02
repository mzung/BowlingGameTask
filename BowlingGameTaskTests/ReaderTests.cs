using BowlingGameTask;
using NUnit.Framework;
using System.Collections.Generic;

namespace BowlingGameTaskTests
{
    public class ReaderTests
    {
        private List<int> rolls;
        [SetUp]
        public void Setup()
        {
            rolls = new List<int>();
            rolls.Add(1);
            rolls.Add(2);
            rolls.Add(3);
        }

        [Test]
        public void GetRollsFromStringTest()
        {
            var result = Reader.GetPins("1, 2, 3");
            Assert.AreEqual(result, rolls);
        }
    }
}
