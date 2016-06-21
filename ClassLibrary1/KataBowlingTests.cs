﻿using KataBowling;
using NUnit.Framework;

namespace KataBowlingTest
{
    [TestFixture]
    public class KataBowlingTests
    {
        [Test]
        public void NoScore()
        {
            var game = new Game();
            for (int i = 0; i < 20; i++)
            {
                game.Roll(0);
            }
            Assert.AreEqual(0, game.Score());
        }
    }
}
